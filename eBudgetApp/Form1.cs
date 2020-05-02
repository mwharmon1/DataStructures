using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

/**************************************************************
* Name        : eBudgetApp
* Author      : Michael Harmon
* Created     : 4/27/2020
* Course      : Data Structures
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program will allow a user to input data
*               to create accounts and transactions to keep
*               track of account balances
*               Input:  Account and transaction data
*               Output: data will display on GUI form
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/
namespace eBudgetApp
{
    public partial class Form1 : Form
    {
        //Create a new transaction queue and new account stack
        TransactionQueue transQueue = new TransactionQueue();
        AccountStack accountStack = new AccountStack();
        Account account = new Account("", "", 0.00);

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TransactionTypeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TransAddButton_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";
            Double amt = 0.00;
            amt = Convert.ToDouble(this.TransAmountTB.Text.ToString(), provider);

            //Create a new transaction using the user input
            Transaction transaction = new Transaction(this.TransactionTypeDDL.SelectedItem.ToString(), this.TransDatePicker.Value, this.TransDescriptionTB.Text.ToString(), amt);

            //Get our transaction data to display in the gridview using the Transaction class methods
            string transType = transaction.GetTransType().ToString();
            string transDate = transaction.GetTransDate().ToString();
            string transDesc = transaction.GetTransDescritpion().ToString();
            string transAmt = transaction.GetTransAmount().ToString();
            dataGridView1.Rows.Add(transType, transDate, transDesc, transAmt);

            //Queue the transaction
            transQueue.Enqueue(transaction);

            //Get the current balance for the account to either add or remove funds
            DataGridViewRow acctRow = this.dataGridView2.SelectedRows[0];
            var acctBalance = Convert.ToDouble(acctRow.Cells["Balance"].Value.ToString(), provider);

            //Do some checks on our data and create the new balance for the given account using the transaction data provided
            double finalAmount = 0.00;
            if (!accountStack.IsEmpty())
            {
                var accounts = accountStack.GetStack();
                foreach (string name in accounts)
                {
                    if (name == AccountDDL.SelectedItem.ToString())
                    {
                        if(transaction.GetTransType().ToString() == "Incoming")
                        {
                            finalAmount = acctBalance + amt;
                            this.account.SetAcountAmount(finalAmount);
                        }
                        else
                        {
                            finalAmount = acctBalance - amt;
                            this.account.SetAcountAmount(finalAmount);
                        }
                        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                dataGridView2.Rows.Remove(row);
                            }
                        }
                    }

                }

                //Add the updated account with the new balance back to the gridview
                dataGridView2.Rows.Add(this.AccountTypeDDL.SelectedItem.ToString(), this.AccountNameTB.Text.ToString(), finalAmount);
            }

            //Clear our text boxes for next input
            TransactionTypeDDL.Text = " ";
            TransDatePicker.Value = DateTime.Now;
            TransDescriptionTB.Text = " ";
            TransAmountTB.Text = " ";
        }

        private void TransDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void TransDescriptionTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void TransAmountTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void TransListBox_SelectedIndexChanged(object sender, EventArgs e)
        {        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AccountTypeDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AccountAddButton_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";
            Double amt = 0.00;
            amt = Convert.ToDouble(this.AccountAmountTB.Text.ToString(), provider);

            //Create the new account using the Account class
            account = new Account(this.AccountTypeDDL.SelectedItem.ToString(), this.AccountNameTB.Text.ToString(), amt);

            //Push the new account to the stack
            accountStack.Push(account);

            //Get all of our values that were inputted using the Account class methods
            string accountType = account.GetAccountType().ToString();
            string accountName = account.GetAccountName().ToString();
            string accountAmount = account.GetAcountAmount().ToString();

            //Add the new account to the gridview
            dataGridView2.Rows.Add(accountType, accountName, accountAmount);

            //Add our current accounts to the drop down list using Account class method
            AccountDDL.Items.Add(account.GetAccountName());

        }

        private void AccountAmountTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void label_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void eBudget_Click(object sender, EventArgs e)
        {
        }

        private void accountDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void AccountNameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView2.Columns.Clear();
            this.accountStack.SortStack();

            for (int i = 0; i < accountStack.StackSize(); i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = accountStack.GetType(i);
                dataGridView2.Rows[i].Cells[1].Value = accountStack.GetName(i);
                dataGridView2.Rows[i].Cells[2].Value = accountStack.GetAmount(i).ToString();
            }
        }
    }
}
