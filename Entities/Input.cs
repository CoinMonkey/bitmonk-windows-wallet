using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMonk.Entities
{
    class Input
    {
        decimal amount;
        string address;

        public Input(decimal setAmount, string setAddress)
        {
            amount = setAmount;
            address = setAddress;
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
