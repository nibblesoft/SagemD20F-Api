using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagemRouterClient
{
    public partial class LoginForm : Form
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            string userName = GetVariableValue("router_username");
            string password = GetVariableValue("router_password");

            if (!string.IsNullOrEmpty(userName))
            {
                textBoxUserName.Text = userName;
            }
            if (!string.IsNullOrEmpty(password))
            {
                textBoxPassword.Text = password;
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // NOTE: Trim spaces?
            UserName = textBoxUserName.Text;
            Password = textBoxPassword.Text;

            DialogResult = DialogResult.OK;

            MessageBox.Show("Note: this won't login the user directly into the client router!");
        }

        private static string GetVariableValue(string varName) => Environment.GetEnvironmentVariable(varName, EnvironmentVariableTarget.User);
    }
}
