using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinLib.Services.Coins.Base;

namespace BitMonk
{
    public partial class SettingsForm : Form
    {
        private ICoinService CoinService;

        public SettingsForm(ICoinService SetCoinService)
        {
            CoinService = SetCoinService;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.rpcHost = rpcHost.Text;
            Properties.Settings.Default.rpcPort = rpcPort.Text;
            Properties.Settings.Default.rpcLogin = rpcLogin.Text;
            Properties.Settings.Default.rpcPassword = rpcPassword.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.account = account.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Done");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            rpcHost.Text = Properties.Settings.Default.rpcHost;
            rpcPort.Text = Properties.Settings.Default.rpcPort;
            rpcLogin.Text = Properties.Settings.Default.rpcLogin;
            rpcPassword.Text = Properties.Settings.Default.rpcPassword;
            password.Text = Properties.Settings.Default.password;
            account.Text = Properties.Settings.Default.account;

            if (!CoinService.IsWalletEncrypted())
            {
                securityBox.Hide();
            }
        }
    }
}
