using System;
using System.IO;
using System.Windows.Forms;
using BitcoinLib.Services.Coins.Base;
using System.Diagnostics;

namespace BitMonk
{
    public partial class MyMnsForm : Form
    {
        private ICoinService CoinService;

        public MyMnsForm(ICoinService SetCoinService)
        {
            CoinService = SetCoinService;

            InitializeComponent();

            updateMnCoinfig();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void updateMnCoinfig()
        {
            mnConfigTextBox.Text = "";

            string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bitmonk";
            string configFile = applicationDataPath + "\\masternode.conf";

            if (!File.Exists(configFile))
            {
                File.Copy("masternode.conf-example", applicationDataPath + "\\masternode.conf");
                mnConfigTextBox.Text = "";
            }
            else
            {
                mnConfigTextBox.Text = File.ReadAllText(configFile);
            }
        }

        private void MyMnsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic answer = CoinService.ControlMasternode("start-many");

            MessageBox.Show(answer.overall.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic answer = CoinService.ControlMasternode("stop-many");

            MessageBox.Show(answer.overall.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bitmonk\\masternode.conf";

            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + applicationDataPath));
        }
    }
}
