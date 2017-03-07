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
        private readonly SagemClient _sagemClient;

        public Main()
        {
            InitializeComponent();
            _sagemClient = new SagemClient();
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
            await _sagemClient.AddMacAddressAsync(textBoxMac.Text).ConfigureAwait(false);
        }

        private async void buttonRemoveMac_Click(object sender, EventArgs e)
        {
            await _sagemClient.RemoveMacAddress(textBoxMac.Text).ConfigureAwait(false);
        }
    }
}
