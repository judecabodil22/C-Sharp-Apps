﻿using System;
using System.Windows.Forms;

namespace Budgetary_Desktop_App_Expanded
{
    public partial class AddExpensesForm : Form
    {
        private Label lblExpenseName;
        internal TextBox txtExpenseName;
        private Label lblCategory;
        internal ComboBox cmbCategory;
        private Label lblAmount;
        internal TextBox txtAmount;
        private CheckBox chkRecurring;
        private Button btnAddExpense;
        private Button btnCancel;

        public AddExpensesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblExpenseName = new Label();
            txtExpenseName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            chkRecurring = new CheckBox();
            btnAddExpense = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Location = new Point(20, 20);
            lblExpenseName.Name = "lblExpenseName";
            lblExpenseName.Size = new Size(88, 15);
            lblExpenseName.TabIndex = 0;
            lblExpenseName.Text = "Expense Name:";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(130, 20);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(200, 23);
            txtExpenseName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new object[] { "Food", "Transport", "Utilities", "Entertainment", "Other" });
            cmbCategory.Location = new Point(130, 60);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 100);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(130, 100);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 5;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(130, 130);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(104, 19);
            chkRecurring.TabIndex = 6;
            chkRecurring.Text = "Recurring Bill";
            chkRecurring.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(130, 160);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(100, 30);
            btnAddExpense.TabIndex = 7;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 160);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddExpensesForm
            // 
            ClientSize = new Size(350, 220);
            Controls.Add(lblExpenseName);
            Controls.Add(txtExpenseName);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(chkRecurring);
            Controls.Add(btnAddExpense);
            Controls.Add(btnCancel);
            Name = "AddExpensesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Expense";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            this.Close();
        }
    }
}