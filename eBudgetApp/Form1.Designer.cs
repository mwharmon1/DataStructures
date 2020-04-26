namespace eBudgetApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eBudget = new System.Windows.Forms.Label();
            this.TransactionTypeDDL = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TransDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TransDescriptionTB = new System.Windows.Forms.TextBox();
            this.TransAmountLabel = new System.Windows.Forms.Label();
            this.TransAmountTB = new System.Windows.Forms.TextBox();
            this.TransAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountTypeDDL = new System.Windows.Forms.ComboBox();
            this.AccountAmountLabel = new System.Windows.Forms.Label();
            this.AccountAmountTB = new System.Windows.Forms.TextBox();
            this.AccountAddButton = new System.Windows.Forms.Button();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.AccountNameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDDL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // eBudget
            // 
            this.eBudget.AutoSize = true;
            this.eBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBudget.Location = new System.Drawing.Point(353, 20);
            this.eBudget.Name = "eBudget";
            this.eBudget.Size = new System.Drawing.Size(181, 24);
            this.eBudget.TabIndex = 0;
            this.eBudget.Text = "eBudgetCalculator";
            this.eBudget.Click += new System.EventHandler(this.eBudget_Click);
            // 
            // TransactionTypeDDL
            // 
            this.TransactionTypeDDL.FormattingEnabled = true;
            this.TransactionTypeDDL.Items.AddRange(new object[] {
            "Incoming",
            "Outgoing"});
            this.TransactionTypeDDL.Location = new System.Drawing.Point(19, 370);
            this.TransactionTypeDDL.Name = "TransactionTypeDDL";
            this.TransactionTypeDDL.Size = new System.Drawing.Size(117, 21);
            this.TransactionTypeDDL.TabIndex = 2;
            this.TransactionTypeDDL.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeDDL_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(16, 354);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(139, 354);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date:";
            // 
            // TransDatePicker
            // 
            this.TransDatePicker.Location = new System.Drawing.Point(142, 371);
            this.TransDatePicker.Name = "TransDatePicker";
            this.TransDatePicker.Size = new System.Drawing.Size(200, 20);
            this.TransDatePicker.TabIndex = 5;
            this.TransDatePicker.ValueChanged += new System.EventHandler(this.TransDatePicker_ValueChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(345, 354);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description:";
            // 
            // TransDescriptionTB
            // 
            this.TransDescriptionTB.Location = new System.Drawing.Point(348, 371);
            this.TransDescriptionTB.Name = "TransDescriptionTB";
            this.TransDescriptionTB.Size = new System.Drawing.Size(282, 20);
            this.TransDescriptionTB.TabIndex = 7;
            this.TransDescriptionTB.TextChanged += new System.EventHandler(this.TransDescriptionTB_TextChanged);
            // 
            // TransAmountLabel
            // 
            this.TransAmountLabel.AutoSize = true;
            this.TransAmountLabel.Location = new System.Drawing.Point(633, 354);
            this.TransAmountLabel.Name = "TransAmountLabel";
            this.TransAmountLabel.Size = new System.Drawing.Size(55, 13);
            this.TransAmountLabel.TabIndex = 8;
            this.TransAmountLabel.Text = "Amount: $";
            // 
            // TransAmountTB
            // 
            this.TransAmountTB.Location = new System.Drawing.Point(636, 370);
            this.TransAmountTB.Name = "TransAmountTB";
            this.TransAmountTB.Size = new System.Drawing.Size(100, 20);
            this.TransAmountTB.TabIndex = 9;
            this.TransAmountTB.Text = "0.00";
            this.TransAmountTB.TextChanged += new System.EventHandler(this.TransAmountTB_TextChanged);
            // 
            // TransAddButton
            // 
            this.TransAddButton.Location = new System.Drawing.Point(869, 365);
            this.TransAddButton.Name = "TransAddButton";
            this.TransAddButton.Size = new System.Drawing.Size(75, 23);
            this.TransAddButton.TabIndex = 10;
            this.TransAddButton.Text = "Add";
            this.TransAddButton.UseVisualStyleBackColor = true;
            this.TransAddButton.Click += new System.EventHandler(this.TransAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Type:";
            // 
            // AccountTypeDDL
            // 
            this.AccountTypeDDL.FormattingEnabled = true;
            this.AccountTypeDDL.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Credit"});
            this.AccountTypeDDL.Location = new System.Drawing.Point(19, 94);
            this.AccountTypeDDL.Name = "AccountTypeDDL";
            this.AccountTypeDDL.Size = new System.Drawing.Size(121, 21);
            this.AccountTypeDDL.TabIndex = 15;
            this.AccountTypeDDL.SelectedIndexChanged += new System.EventHandler(this.AccountTypeDDL_SelectedIndexChanged);
            // 
            // AccountAmountLabel
            // 
            this.AccountAmountLabel.AutoSize = true;
            this.AccountAmountLabel.Location = new System.Drawing.Point(317, 78);
            this.AccountAmountLabel.Name = "AccountAmountLabel";
            this.AccountAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AccountAmountLabel.TabIndex = 16;
            this.AccountAmountLabel.Text = "Amount:";
            // 
            // AccountAmountTB
            // 
            this.AccountAmountTB.Location = new System.Drawing.Point(317, 95);
            this.AccountAmountTB.Name = "AccountAmountTB";
            this.AccountAmountTB.Size = new System.Drawing.Size(100, 20);
            this.AccountAmountTB.TabIndex = 17;
            this.AccountAmountTB.TextChanged += new System.EventHandler(this.AccountAmountTB_TextChanged);
            // 
            // AccountAddButton
            // 
            this.AccountAddButton.Location = new System.Drawing.Point(438, 95);
            this.AccountAddButton.Name = "AccountAddButton";
            this.AccountAddButton.Size = new System.Drawing.Size(75, 23);
            this.AccountAddButton.TabIndex = 18;
            this.AccountAddButton.Text = "Add";
            this.AccountAddButton.UseVisualStyleBackColor = true;
            this.AccountAddButton.Click += new System.EventHandler(this.AccountAddButton_Click);
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Location = new System.Drawing.Point(147, 78);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(81, 13);
            this.AccountNameLabel.TabIndex = 21;
            this.AccountNameLabel.Text = "Account Name:";
            // 
            // AccountNameTB
            // 
            this.AccountNameTB.Location = new System.Drawing.Point(150, 95);
            this.AccountNameTB.Name = "AccountNameTB";
            this.AccountNameTB.Size = new System.Drawing.Size(161, 20);
            this.AccountNameTB.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Date,
            this.Description,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(181, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(476, 198);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountType,
            this.Account,
            this.Balance});
            this.dataGridView2.Location = new System.Drawing.Point(181, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(332, 150);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Type";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account Name";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(11, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 20);
            this.label.TabIndex = 25;
            this.label.Text = "Accounts";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Transactions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // AccountDDL
            // 
            this.AccountDDL.FormattingEnabled = true;
            this.AccountDDL.Location = new System.Drawing.Point(742, 367);
            this.AccountDDL.Name = "AccountDDL";
            this.AccountDDL.Size = new System.Drawing.Size(121, 21);
            this.AccountDDL.TabIndex = 27;
            this.AccountDDL.SelectedIndexChanged += new System.EventHandler(this.accountDDL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Account:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountDDL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AccountNameTB);
            this.Controls.Add(this.AccountNameLabel);
            this.Controls.Add(this.AccountAddButton);
            this.Controls.Add(this.AccountAmountTB);
            this.Controls.Add(this.AccountAmountLabel);
            this.Controls.Add(this.AccountTypeDDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransAddButton);
            this.Controls.Add(this.TransAmountTB);
            this.Controls.Add(this.TransAmountLabel);
            this.Controls.Add(this.TransDescriptionTB);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TransDatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TransactionTypeDDL);
            this.Controls.Add(this.eBudget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eBudget;
        private System.Windows.Forms.ComboBox TransactionTypeDDL;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker TransDatePicker;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TransDescriptionTB;
        private System.Windows.Forms.Label TransAmountLabel;
        private System.Windows.Forms.TextBox TransAmountTB;
        private System.Windows.Forms.Button TransAddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AccountTypeDDL;
        private System.Windows.Forms.Label AccountAmountLabel;
        public System.Windows.Forms.TextBox AccountAmountTB;
        private System.Windows.Forms.Button AccountAddButton;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.TextBox AccountNameTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ComboBox AccountDDL;
        private System.Windows.Forms.Label label1;
    }
}

