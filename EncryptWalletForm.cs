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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CoinService.WalletPassphraseChange(passwordOld.Text, passwordNew.Text);

                Properties.Settings.Default.password = passwordNew.Text;
                Properties.Settings.Default.Save();

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
