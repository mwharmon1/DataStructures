using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    public class Transaction
    {
        private string _transType = "";
        private DateTime _transDate = DateTime.Now;
        private string _transDescription = "";
        private double _transAmount = 0.00;

        public Transaction(string type, DateTime date, string desc, double amt)
        {
            this._transType = type;
            this._transDate = date;
            this._transDescription = desc;
            this._transAmount = amt;
        }

        public string GetTransType()
        {
            return this._transType;
        }

        public void SetTransType(string type)
        {
            this._transType = type;
        }

        public DateTime GetTransDate()
        {
            return this._transDate;
        }

        public void SetTransDate(DateTime date)
        {
            this._transDate = date;
        }

        public string GetTransDescritpion()
        {
            return this._transDescription;
        }

        public void SetTransDescription(string description)
        {
            this._transDescription = description;
        }

        public double GetTransAmount()
        {
            return this._transAmount;
        }

        public void SetTransAmount(double amount)
        {
            this._transAmount = amount;
        }

    }
}
