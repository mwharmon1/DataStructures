using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    public class Transaction
    {
        /***************************************************************
        * Name        : Transaction
        * Author      : Michael Harmon
        * Created     : 4/27/2020
        ***************************************************************/
        private string _transType = "";
        private DateTime _transDate = DateTime.Now;
        private string _transDescription = "";
        private double _transAmount = 0.00;


        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Transaction
        * Description: Create a new transaction
        * Input parameters: string type, DateTime date, string desc, double amt
        ***************************************************************/
        public Transaction(string type, DateTime date, string desc, double amt)
        {
            this._transType = type;
            this._transDate = date;
            this._transDescription = desc;
            this._transAmount = amt;
        }

        /**************************************************************
        * Name: GetTransType
        * Description: Get and return the transaction type
        * Input: none
        * Output: string transType
        ***************************************************************/
        public string GetTransType()
        {
            return this._transType;
        }

        /**************************************************************
        * Name: SetTransType
        * Description: Set the trans type
        * Input: string type
        * Output: none
        ***************************************************************/
        public void SetTransType(string type)
        {
            this._transType = type;
        }


        /**************************************************************
        * Name: GetTransDate
        * Description: Get the trans date
        * Input: none
        * Output: string transDate
        ***************************************************************/
        public DateTime GetTransDate()
        {
            return this._transDate;
        }

        /**************************************************************
        * Name: SetTransDate
        * Description: Set the trans date
        * Input: DateTime date
        * Output: none
        ***************************************************************/
        public void SetTransDate(DateTime date)
        {
            this._transDate = date;
        }

        /**************************************************************
        * Name: GetTransDescritpion
        * Description: Get and return the trans description
        * Input: none
        * Output: string transDescription
        ***************************************************************/
        public string GetTransDescritpion()
        {
            return this._transDescription;
        }

        /**************************************************************
        * Name: SetTransDescription
        * Description: Set the transDescription
        * Input: string description
        * Output: none
        ***************************************************************/
        public void SetTransDescription(string description)
        {
            this._transDescription = description;
        }

        /**************************************************************
        * Name: GetTransAmount
        * Description: Get and return the transAmount
        * Input: none
        * Output: double transAmount
        ***************************************************************/
        public double GetTransAmount()
        {
            return this._transAmount;
        }

        /**************************************************************
        * Name: SetTransAmount
        * Description: Set the transAmount
        * Input: double amount
        * Output: none
        ***************************************************************/
        public void SetTransAmount(double amount)
        {
            this._transAmount = amount;
        }

    }
}
