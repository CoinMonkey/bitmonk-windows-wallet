using System;
using System.Net;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using BitcoinLib.Responses;
using BitcoinLib.Services.Coins.Cryptocoin;
using BitcoinLib.Services.Coins.Base;
using System.Diagnostics;
using BitcoinLib.Auxiliary;
using System.ComponentModel;

namespace BitMonk
{
    public partial class MainForm : Form
    {
        private GetInfoResponse info;
        private static readonly ICoinService CoinService = new CryptocoinService("http://127.0.0.1:37771", "p1", "p2", null);
        private bool daemonLaunched;
        private Process daemonProcess;
        private string lastCheckBalance;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logMessageLabel.Text = "Welcome! Trying to launch daemon...";

            checkInstall();
            launchRpc();

            Timer tmr = new Timer();
            tmr.Interval = 6000; 
            tmr.Tick += timerHandler; 
            tmr.Start();

            updateTransactionsList();
            updateMasternodesList();
        }

        private void timerHandler(object sender, EventArgs e)
        {
            logMessageLabel.Text = "";
            updateStat();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Closing");
            daemonProcess.Close();
        }

        private void checkInstall()
        {
            string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bitmonk";
            string configFile = applicationDataPath + "\\Bitmonk.conf";

            if (!Directory.Exists(applicationDataPath))
            {
                Directory.CreateDirectory(applicationDataPath);
            }

            if (!File.Exists(configFile))
            {
                File.Copy("Bitmonk.conf-example", applicationDataPath + "\\Bitmonk.conf");
            }
            else
            {
                long length = new System.IO.FileInfo(configFile).Length;

                if (length == 0)
                {
                    File.Copy("Bitmonk.conf-example", applicationDataPath + "\\Bitmonk.conf");
                }
            }
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            updateStat();
        }

        private void launchRpc()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "bitmonkd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            daemonProcess = new Process();
            daemonProcess.StartInfo = startInfo;
            daemonProcess.Start();

            daemonLaunched = true;
        }

        private void updateTransactionsList()
        {
            try
            {
                Collections.Transactions list = new Collections.Transactions();

                var myTransactions = CoinService.ListTransactions(null, int.MaxValue, 0);
                int i = 1;

                foreach (var data in myTransactions)
                {
                    if (i <= 2000)
                    {
                        Entities.Transaction transaction = new Entities.Transaction(data.TxId, data.Amount, UnixTime.UnixTimeToDateTime(data.Time).ToShortDateString() + " " + UnixTime.UnixTimeToDateTime(data.Time).ToShortTimeString(), data.Category, data.Confirmations);
                        list.Add(transaction);
                    }

                    i++;
                }

                list.Reverse();

                transactionsGridView.DataSource = list;
                transactionsGridView.Update();
                transactionsGridView.Focus();
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcException source: {0}", exc.Source);
                }
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcInternalServerErrorException source: {0}", exc.Source);
                }
            }
            catch (WebException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("WebException source: {0}", exc.Source);
                }
            }
        }

        private void updateMasternodesList()
        {
            try
            {
                Collections.Masternodes list = new Collections.Masternodes();

                dynamic masternodes = CoinService.ListMasternodes();
                
                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(masternodes))
                {
                    string mnInfo = masternodes[prop.Name].ToString().Trim();
                    string[] mnParams = mnInfo.Split(' ');
                    Entities.Masternode masternode = new Entities.Masternode(mnParams[0], mnParams[3], mnParams[1], UnixTime.UnixTimeToDateTime(Convert.ToDouble(mnParams[4])).ToShortTimeString());
                    list.Add(masternode);
                }

                list.Reverse();

                masternodesGridView.DataSource = list;
                masternodesGridView.Update();
                masternodesGridView.Focus();
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcException source: {0}", exc.Source);
                }
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcInternalServerErrorException source: {0}", exc.Source);
                }
            }
            catch (WebException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("WebException source: {0}", exc.Source);
                }
            }
        }

        private void updateStat()
        {
            try
            {
                info = CoinService.GetInfo();
                string inputsCount = CoinService.ListUnspent().Count().ToString();

                string masternodeCount = CoinService.GetMasternode("count");

                balanceLabel.Text = info.Balance.ToString() + " BMO";
                currentAddressLabel.Text = CoinService.GetAccountAddress("windowswallet").ToString();
                peersCountLabel.Text = "Peers: " + CoinService.GetPeerInfo().Count().ToString();
                stakeLinkLabel.Text = info.Stake.ToString() + " BMO";
                //connectionsLabel.Text = "Connections: " + info.Connections.ToString();
                syncLabel.Text = "Sync: " + info.Blocks + "b.";
                pVerLabel.Text = info.Version;
                mnCounLabel.Text = "MN count: " + masternodeCount;
                inputsCountLabel.Text = inputsCount;

                string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bitmonk";
                string configFile = applicationDataPath + "\\masternode.conf";

                if (!File.Exists(configFile))
                {
                    File.Copy("masternode.conf-example", applicationDataPath + "\\masternode.conf");
                }

                myMnsCountLabel.Text = File.ReadAllLines(configFile).Count().ToString();
                
                if (lastCheckBalance != balanceLabel.Text)
                {
                    updateTransactionsList();
                }

                lastCheckBalance = balanceLabel.Text;
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcException source: {0}", exc.Source);
                }
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("RpcInternalServerErrorException source: {0}", exc.Source);
                }
            }
            catch (WebException exc)
            { 
                if (exc.Source != null)
                {
                    logMessageLabel.Text = exc.Message;
                    Console.WriteLine("WebException source: {0}", exc.Source);
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            String address = sendAddressInput.Text;
            Decimal amount = Convert.ToDecimal(sendAmountInput.Text.Replace('.', ','));
            String comment = sendCommentInput.Text;

            try
            {
                String txId = CoinService.SendFrom("windowswallet", address, amount);

                if (txId != "")
                {
                    SuccessTxForm txForm = new SuccessTxForm(txId);
                    txForm.Show();
                }
                else
                {
                    MessageBox.Show("Unknown Error. Check out your daemon.");
                }
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            catch (WebException exc)
            { 
                if (exc.Source != null)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            
            updateStat();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void currentAddressLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentAddressLabel_Click(object sender, EventArgs e)
        {
            currentAddressLabel.Select();
        }

        private void newAddressButton_Click(object sender, EventArgs e)
        {
            currentAddressLabel.Text = CoinService.GetNewAddress("windowswallet");
        }

        private void sendAmountInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void commandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "bitmonkd";
                    process.StartInfo.Arguments = commandBox.Text;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    process.WaitForExit();
                    process.Close();

                    consoleTextBox.Text = output;

                    commandBox.Text = "";
                }
                catch (System.InvalidOperationException exc)
                {
                    MessageBox.Show("Daemon doesn't launched yet. Please wait a bit! " + exc.Message);
                }
            }
        }

        private void commandBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mnUpdateButton_Click(object sender, EventArgs e)
        {
            updateMasternodesList();
        }

        private void stakeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputsForm inputsForm = new InputsForm(CoinService);
            inputsForm.Show();
        }

        private void inputsCountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputsForm inputsForm = new InputsForm(CoinService);
            inputsForm.Show();
        }

        private void myMnsCountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyMnsForm myMnsForm = new MyMnsForm(CoinService);
            myMnsForm.Show();
        }

        private void mnAddButton_Click(object sender, EventArgs e)
        {
            MyMnsForm myMnsForm = new MyMnsForm(CoinService);
            myMnsForm.Show();
        }
    }
}
