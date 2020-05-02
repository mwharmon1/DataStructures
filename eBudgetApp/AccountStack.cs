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
        * Name: Pop
        * Description: Pop an account from the stack
        * Input: Account object
        * Output: none
        ***************************************************************/
        public Account Pop(Account account)
        {
            if (top == -1)
            {
                return this.accounts[this.top];
            }
            else
            {
                return this.accounts[top--];
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

        /**************************************************************
        * Name: SortStack
        * Description: sort the stack small to high
        * Input: none
        * Output: none
        ***************************************************************/
        public void SortStack()
        {
            int n = this.accounts.Length;
            for(int i = 0; i < this.accounts.Length; i++)
            {
                if(this.accounts[i] == null)
                {
                    n -= 1;
                }
            }

            for(int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (this.accounts[j].GetAcountAmount() > this.accounts[j + 1].GetAcountAmount())
                    {
                        Account tempAccount = this.accounts[j];
                        this.accounts[j] = this.accounts[j + 1];
                        this.accounts[j + 1] = tempAccount;
                    }
                }
            }
        }

        /**************************************************************
        * Name: StackSize
        * Description: return a list of the account names
        * Input: none
        * Output: list of account names
        ***************************************************************/
        public int StackSize()
        {
            return top + 1;
        }

        /**************************************************************
        * Name: GetName
        * Description: return a list of the account names
        * Input: none
        * Output: list of account names
        ***************************************************************/
        public string GetName(int i)
        {
            return this.accounts[i].GetAccountName();
        }

        /**************************************************************
        * Name: GetType
        * Description: return a list of the account names
        * Input: none
        * Output: list of account names
        ***************************************************************/
        public string GetType(int i)
        {
            return this.accounts[i].GetAccountType();
        }

        /**************************************************************
        * Name: GetAmount
        * Description: return a list of the account names
        * Input: none
        * Output: list of account names
        ***************************************************************/
        public double GetAmount(int i)
        {
            return this.accounts[i].GetAcountAmount();
        }
    }
}
