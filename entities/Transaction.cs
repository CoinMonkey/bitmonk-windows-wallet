using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMonk.entities
{
    class Transaction
    {
        string id;
        decimal amount;
        string date;
        string type;
        int conf;

        public Transaction(string setId, decimal setAmount, string setDate, string setType, int setConf)
        {
            id = setId;
            amount = setAmount;
            date = setDate;
            type = setType;
            conf = setConf;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Conf
        {
            get { return conf; }
            set { conf = value; }
        }
    }
}
