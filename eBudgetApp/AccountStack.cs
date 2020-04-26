using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    public class AccountStack
    {
        private int stackSize = 5;
        private Account[] accounts;
        private int top = -1;

        public AccountStack()
        {
            this.accounts = new Account[stackSize];
        }

        public void Push(Account account)
        {
            if (top <= 3)
            {
                top = top + 1;
                this.accounts[top] = account;
            }
            else
            {
                Console.WriteLine("Test.");
            }
        }






        public bool IsEmpty()
        {
            if (top <= -1)
            {
                return true;
            }
            return false;
        }

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
