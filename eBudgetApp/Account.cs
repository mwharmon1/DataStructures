using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    public class Account
    {
        private string _type = "";
        private string _accountName = "";
        private double _amount = 0.00;

        public Account(string type, string name, double amount)
        {
            this._type = type;
            this._accountName = name;
            this._amount = amount;
        }

        public string GetAccountType()
        {
            return this._type;
        }

        public string GetAccountName()
        {
            return this._accountName;
        }

        public double GetAcountAmount()
        {
            return this._amount;
        }


    }
}
