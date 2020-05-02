using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    /***************************************************************
    * Name        : Account
    * Author      : Michael Harmon
    * Created     : 4/27/2020
    ***************************************************************/
    public class Account
    {
        private string _type = "";
        private string _accountName = "";
        private double _amount = 0.00;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Account
        * Description: Create a new account
        * Input parameters: string type, string name, double amount
        ***************************************************************/
        public Account(string type, string name, double amount)
        {
            this._type = type;
            this._accountName = name;
            this._amount = amount;
        }

        /**************************************************************
        * Name: GetAccountType
        * Description: Get and return the type of account
        * Input: None
        * Output: string type
        ***************************************************************/
        public string GetAccountType()
        {
            return this._type;
        }

        /**************************************************************
        * Name: GetAccountName
        * Description: Get and return the account name
        * Input: None
        * Output: string type
        ***************************************************************/
        public string GetAccountName()
        {
            return this._accountName;
        }

        /**************************************************************
        * Name: GetAcountAmount
        * Description: Get and return the account amount
        * Input: None
        * Output: double amount
        ***************************************************************/
        public double GetAcountAmount()
        {
            return this._amount;
        }

        /**************************************************************
        * Name: SetAcountAmount
        * Description: Get and return the account amount
        * Input: None
        * Output: double amount
        ***************************************************************/
        public void SetAcountAmount(double amount)
        {
            this._amount = amount;
        }


    }
}
