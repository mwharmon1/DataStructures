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

namespace eBudgetApp
{
    public partial class Form1 : Form
    {
        TransactionQueue transQueue = new TransactionQueue();
        AccountStack accountStack = new AccountStack();

        public void Form1_Load(object sender, EventArgs e)
        {
            //AccountDDL.Visible = false;
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

            Transaction transaction = new Transaction(this.TransactionTypeDDL.SelectedItem.ToString(), this.TransDatePicker.Value, this.TransDescriptionTB.Text.ToString(), amt);
            string transType = transaction.GetTransType().ToString();
            string transDate = transaction.GetTransDate().ToString();
            string transDesc = transaction.GetTransDescritpion().ToString();
            string transAmt = transaction.GetTransAmount().ToString();
            dataGridView1.Rows.Add(transType, transDate, transDesc, transAmt);

            transQueue.Enqueue(transaction);

            double amt1 = Convert.ToDouble(this.TransAmountTB.Text.ToString(), provider);
            double amt2 = Convert.ToDouble(this.AccountAmountTB.Text.ToString(), provider);
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
                            finalAmount = amt2 + amt1;
                        }
                        else
                        {
                            finalAmount = amt2 - amt1;
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
                dataGridView2.Rows.Add(this.AccountTypeDDL.SelectedItem.ToString(), this.AccountNameTB.Text.ToString(), finalAmount);
            }

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

            Account account = new Account(this.AccountTypeDDL.SelectedItem.ToString(), this.AccountNameTB.Text.ToString(), amt);

            accountStack.Push(account);

            string accountType = account.GetAccountType().ToString();
            string accountName = account.GetAccountName().ToString();
            string accountAmount = account.GetAcountAmount().ToString();
            dataGridView2.Rows.Add(accountType, accountName, accountAmount);

            AccountDDL.Items.Add(account.GetAccountName());

            //amt = Convert.ToDouble(this.AccountDDL.Text.ToString(), provider);

            //if (!accountStack.IsEmpty())
            //{
            //    var accounts = accountStack.GetStack();
            //    foreach (string name in accounts)
            //    {
                    
            //    }
            //}

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
    }
}
