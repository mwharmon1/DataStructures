using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    /***************************************************************
    * Name        : AccountStack
    * Author      : Michael Harmon
    * Created     : 4/27/2020
    ***************************************************************/
    public class AccountStack
    {
        private int stackSize = 5;
        private Account[] accounts;
        private int top = -1;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: AccountStack
        * Description: Create a new account stack to store accounts
        * Input parameters: none
        ***************************************************************/
        public AccountStack()
        {
            this.accounts = new Account[stackSize];
        }

        /**************************************************************
        * Name: Push
        * Description: Add a new account to the stack
        * Input: Account object
        * Output: none
        ***************************************************************/
        public void Push(Account account)
        {
            if (top <= 3)
            {
                top = top + 1;
                this.accounts[top] = account;
            }
            else
            {
               //do nothing
            }
        }

        /**************************************************************
        * Name: IsEmpty
        * Description: Check to see if stack is empty
        * Input: None
        * Output: none
        ***************************************************************/
        public bool IsEmpty()
        {
            if (top <= -1)
            {
                return true;
            }
            return false;
        }

        /**************************************************************
        * Name: GetStack
        * Description: return a list of the account names
        * Input: none
        * Output: list of account names
        ***************************************************************/
        public List<string> GetStack()
        {
            var accountList = new List<String>();
            
            foreach(var a in this.accounts)
            {
                if(a != null)
                {
                    string accountName = a.GetAccountName();
                    accountList.Add(accountName);
                }
            }
            return accountList;
        }
    }
}
