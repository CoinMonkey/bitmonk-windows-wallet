using System;
using System.Windows.Forms;
using BitcoinLib.Services.Coins.Base;

namespace BitMonk
{
    public partial class EncryptWalletForm : Form
    {
        private ICoinService CoinService;

        public EncryptWalletForm(ICoinService SetCoinService)
        {
            CoinService = SetCoinService;

            InitializeComponent();

            if (!CoinService.IsWalletEncrypted())
            {
                passwordOld.Hide();
                label1.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CoinService.IsWalletEncrypted())
                {
                    CoinService.WalletPassphraseChange(passwordOld.Text, passwordNew.Text);
                }
                else
                {
                    CoinService.EncryptWallet(passwordNew.Text);
                }
                
                Properties.Settings.Default.password = passwordNew.Text;
                Properties.Settings.Default.Save();

                passwordOld.Text = "";
                passwordNew.Text = "";

                MessageBox.Show("Done");
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show("1: " + exc.Message);
                }
            }
        }

        private void EncryptWalletForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
