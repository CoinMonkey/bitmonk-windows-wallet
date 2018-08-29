using System;
using System.ComponentModel;
using System.Linq;
using BitcoinLib.Services.Coins.Base;
using System.Net;
using System.Windows.Forms;

namespace BitMonk
{
    public partial class InputsForm : Form
    {
        private ICoinService CoinService;

        public InputsForm(ICoinService SetCoinService)
        {
            CoinService = SetCoinService;

            InitializeComponent();
        }

        private void InputsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var myInputs = CoinService.ListUnspent();

                totalLabel.Text = "Total: " + myInputs.Count().ToString();

                Collections.Inputs list = new Collections.Inputs();

                int i = 1;

                foreach (var data in myInputs)
                {
                    if (i <= 2000)
                    {
                        Entities.Input input = new Entities.Input(data.Amount, data.Address);
                        list.Add(input);
                    }

                    i++;
                }

                list.Reverse();

                inputsGridView.DataSource = list;
                inputsGridView.Update();
                inputsGridView.Focus();
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcException exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show(exc.Message);
                    Console.WriteLine("RpcException source: {0}", exc.Source);
                }
            }
            catch (BitcoinLib.ExceptionHandling.Rpc.RpcInternalServerErrorException exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show(exc.Message);
                    Console.WriteLine("RpcInternalServerErrorException source: {0}", exc.Source);
                }
            }
            catch (WebException exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show(exc.Message);
                    Console.WriteLine("WebException source: {0}", exc.Source);
                }
            }
        }
    }
}
