using HackSagemRouter;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SagemRouterClient
{
    public partial class Main : Form
    {
        // to prevent congestion that may occur if too much request is beeing sent at short
        // period of time to the router.
        private Timer _timer;
        private SagemClient _sagemClient;

        public Main()
        {
            InitializeComponent();
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    _sagemClient = new SagemClient(loginForm.UserName, loginForm.Password);
                }
                else
                {
                    MessageBox.Show("Router authentification canceled");
                }
            }
            _timer = new Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 1000 * 1;
        }

        int _timerCount = 10;
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_timerCount == 0)
            {
                _timer.Stop();
                _timerCount = 10;
                ControlStatus(true);
                // hide the content...
                labelStatus.Text = string.Empty;
            }
            else
            {
                labelStatus.Text = $"Waiting... {_timerCount--}";
            }
        }

        private async void buttonReboot_Click(object sender, EventArgs e)
        {
            ControlStatus(false);
            await _sagemClient.RebootAsync().ConfigureAwait(false);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            ControlStatus(false);
            await _sagemClient.RefreshAsync().ConfigureAwait(false);
        }

        private async void buttonAddMac_Click(object sender, EventArgs e)
        {
            string macString = textBoxMac.Text;
            macString = macString.Trim();
            ControlStatus(false);
            await _sagemClient.AddMacAddressAsync(macString).ConfigureAwait(false);
        }

        private async void buttonRemoveMac_Click(object sender, EventArgs e)
        {
            string macString = textBoxMac.Text;
            macString = macString.Trim();
            ControlStatus(false);
            await _sagemClient.RemoveMacAddress(macString).ConfigureAwait(false);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Use property to avoit creating new instance every time we re-authenticate
                    _sagemClient = new SagemClient(loginForm.UserName, loginForm.Password);
                }
                else
                {
                    MessageBox.Show("Router authentification canceled");
                }
            }
        }

        private void ControlStatus(bool enableControls)
        {
            // disable all the button that perform http request

            buttonAddMac.Enabled = enableControls;
            buttonRemoveMac.Enabled = enableControls;
            buttonDisconnect.Enabled = enableControls;
            buttonReboot.Enabled = enableControls;
            checkBoxMacFiltering.Enabled = enableControls;
            buttonRefresh.Enabled = enableControls;
            buttonReAuthenticate.Enabled = enableControls;

            if (!enableControls)
            {
                _timer.Start();
            }
        }

        private void buttonBrowseConfiFile_Click(object sender, EventArgs e)
        {
            // backupsettings.conf
            using (var ofd = new OpenFileDialog() { Filter = "Router config|*.conf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxConfigs.Text = ofd.FileName;
                }
            }
        }

        private async void ButtonUploadConfigClickAsync(object sender, EventArgs e) =>
            await _sagemClient.UploadConfigsAsync(textBoxConfigs.Text).ConfigureAwait(false);

        private async void buttonBackup_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string xmlConfig = await _sagemClient.BackUpConfigsAsync();
                    //using (var fs = new FileStream(sfd.FileName, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                    //{
                    //    fs.write
                    //}
                    File.WriteAllText(sfd.FileName, xmlConfig, Encoding.UTF8);
                }
            }
        }

        private async void buttonUpdateMacFiltering_Click(object sender, EventArgs e)
        {
            // NOTE: perform a reboot before sending enable/diable mac
            // becaus router may freeze and prevent connection via RADIOS/WIRELESS...

            ControlStatus(false);

            // _sagemClient.RebootAsync().Wait(1000 * 5);

            // Invalid: _sagemClient.EnableMacFilteringAsync().RunSynchronously();

            // _sagemClient.RebootAsync().ContinueWith((t) => t.
            if (checkBoxMacFiltering.Checked)
            {
                await _sagemClient.EnableMacFilteringAsync().ConfigureAwait(false);

            }
            else
            {
                await _sagemClient.DisableMacFilterAsync().ConfigureAwait(false);
            }
        }
    }
}
