using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackSagemRouter;

namespace SagemRouterClient
{
    public partial class Main : Form
    {
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
        }

        private async void buttonReboot_Click(object sender, EventArgs e)
        {
            await _sagemClient.RebootAsync().ConfigureAwait(false);
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await _sagemClient.RefreshAsync().ConfigureAwait(false);
        }

        private async void buttonAddMac_Click(object sender, EventArgs e)
        {
            string macString = textBoxMac.Text;
            macString = macString.Trim();
            await _sagemClient.AddMacAddressAsync(macString).ConfigureAwait(false);
        }

        private async void buttonRemoveMac_Click(object sender, EventArgs e)
        {
            string macString = textBoxMac.Text;
            macString = macString.Trim();
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
    }
}
