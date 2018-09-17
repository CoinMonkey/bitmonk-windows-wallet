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
using System.Collections.Generic;

namespace BitMonk
{
    public partial class MainForm : Form
    {
        private GetInfoResponse info;
        private static readonly ICoinService CoinService = new CryptocoinService("http://" + Properties.Settings.Default.rpcHost + ":" + Properties.Settings.Default.rpcPort, Properties.Settings.Default.rpcLogin, Properties.Settings.Default.rpcPassword, Properties.Settings.Default.password);
        private bool daemonLaunched;
        private Process daemonProcess;
        private string lastCheckBalance;
        private bool firstLaunchSign = true;
        Dictionary<string, decimal> txCache = new Dictionary<string, decimal>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logMessageLabel.Text = "Welcome! Trying to launch the daemon...";

            checkInstall();
            launchRpc();

            Timer tmr = new Timer();
            tmr.Interval = 12000; 
            tmr.Tick += timerHandler; 
            tmr.Start();

            Timer tmrTx = new Timer();
            tmrTx.Interval = 30000;
            tmrTx.Tick += timerTxHandler;
            tmrTx.Start();
        }

        private void timerTxHandler(object sender, EventArgs e)
        {
            if (!firstLaunchSign)
            {
                updateTransactionsList();
                updateMasternodesList();
            }
        }
        
        private void timerHandler(object sender, EventArgs e)
        {
            if (firstLaunchSign)
            {
                logMessageLabel.Text = "Daemon is launching...";

                firstLaunchSign = false;
            }
            else
            {
                logMessageLabel.Text = "";
                updateStat();
            }
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
                    File.Delete(applicationDataPath + "\\Bitmonk.conf");
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
            daemonProcess.StartInfo.Arguments = " -daemon -reindex";
            daemonProcess.Start();

            daemonLaunched = true;
        }

        private void updateTransactionsList()
        {
            try
            {
                Collections.Transactions list = new Collections.Transactions();

                var myTransactions = CoinService.ListTransactions(null, int.MaxValue, 0);

                myTransactions.Reverse();

                int i = 1;

                foreach (var data in myTransactions)
                {
                    if (i <= 50)
                    {
                        decimal amount = 0;
                        
                        if (txCache.ContainsKey(data.TxId) && data.Category != "immature")
                        {
                            amount = txCache[data.TxId];
                        }
                        else
                        {
                            if (data.Category == "generate")
                            {
                                var details = CoinService.GetTransaction(data.TxId);
                                
                                if (details.Amount < 0) //POS reward
                                {
                                    amount = details.Fee - details.Amount + details.Amount + details.Amount;
                                }

                                //POW | MN or ordinal tx
                                if (amount == 0)
                                {
                                    amount = details.Amount;
                                }
                            }
                            else if (data.Category == "immature")
                            {
                                amount = 0;
                            }
                            else
                            {
                                amount = data.Amount;
                            }

                            if (amount > 0)
                            {
                                txCache.Add(data.TxId, amount);
                            }
                        }

                        Entities.Transaction transaction = new Entities.Transaction(data.TxId, amount, UnixTime.UnixTimeToDateTime(data.Time).ToShortDateString() + " " + UnixTime.UnixTimeToDateTime(data.Time).ToShortTimeString(), data.Category, data.Confirmations, data.Address);
                        list.Add(transaction);
                    }

                    i++;
                }

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
                    Entities.Masternode masternode = new Entities.Masternode(mnParams[0], mnParams[3], mnParams[1], UnixTime.UnixTimeToDateTime(Convert.ToDouble(mnParams[4])).ToShortDateString() + " " + UnixTime.UnixTimeToDateTime(Convert.ToDouble(mnParams[4])).ToShortTimeString());
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
                currentAddressLabel.Text = CoinService.GetAccountAddress(Properties.Settings.Default.account).ToString();
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
            String comment = ""; // sendCommentInput.Text;

            try
            {
                if (Properties.Settings.Default.password != "")
                {
                    CoinService.WalletPassphrase(Properties.Settings.Default.password, 100);
                }

                String txId = CoinService.SendFrom(Properties.Settings.Default.account, address, amount);
                //String txId = CoinService.SendToAddress(address, amount);

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
                    MessageBox.Show("1: " + exc.Message);
                }
            }
            catch (WebException exc)
            { 
                if (exc.Source != null)
                {
                    MessageBox.Show("2: " + exc.Message);
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
            currentAddressLabel.Text = CoinService.GetNewAddress(Properties.Settings.Default.account);
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

        private void SetTimeout(int time, Action function)
        {
            Timer tmr = new Timer();
            tmr.Interval = time;
            tmr.Tick += new EventHandler(delegate (object s, EventArgs ev)
            {
                function();
                tmr.Stop();
            });
            tmr.Start();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "bitmonkd";
            process.StartInfo.Arguments = "stop";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Focus();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Focus();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Focus();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(CoinService);
            settingsForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void encryptWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptWalletForm encryptForm = new EncryptWalletForm(CoinService);
            encryptForm.Show();
        }
    }
}
