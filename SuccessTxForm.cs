using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMonk
{
    public partial class SuccessTxForm : Form
    {
        String txId;

        public SuccessTxForm(String newTxId)
        {
            txId = newTxId;
            InitializeComponent();
        }

        private void SuccessTxForm_Load(object sender, EventArgs e)
        {
            txIdInput.Text = txId;
        }
    }
}
