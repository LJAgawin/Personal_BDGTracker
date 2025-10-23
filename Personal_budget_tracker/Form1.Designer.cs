namespace Personal_budget_tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnAddExpenses = new Button();
            btnAddIncome = new Button();
            tbxExpenseAmt = new TextBox();
            tbxExpenseDesc = new TextBox();
            tbxIncome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colDesc = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 200);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 17);
            label1.Name = "label1";
            label1.Size = new Size(516, 44);
            label1.TabIndex = 0;
            label1.Text = "PERSONAL BUDGET TRACKER";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnAddExpenses);
            panel2.Controls.Add(btnAddIncome);
            panel2.Controls.Add(tbxExpenseAmt);
            panel2.Controls.Add(tbxExpenseDesc);
            panel2.Controls.Add(tbxIncome);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 367);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(18, 73);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 10;
            label7.Text = "Balance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(18, 45);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 9;
            label6.Text = "Total Expenses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(18, 17);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 8;
            label5.Text = "Total Income:";
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Location = new Point(648, 191);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(117, 23);
            btnAddExpenses.TabIndex = 7;
            btnAddExpenses.Text = "Add Expenses";
            btnAddExpenses.UseVisualStyleBackColor = true;
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(513, 125);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(117, 23);
            btnAddIncome.TabIndex = 6;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += button1_Click;
            // 
            // tbxExpenseAmt
            // 
            tbxExpenseAmt.Location = new Point(207, 191);
            tbxExpenseAmt.Name = "tbxExpenseAmt";
            tbxExpenseAmt.Size = new Size(422, 23);
            tbxExpenseAmt.TabIndex = 5;
            // 
            // tbxExpenseDesc
            // 
            tbxExpenseDesc.Location = new Point(207, 158);
            tbxExpenseDesc.Name = "tbxExpenseDesc";
            tbxExpenseDesc.Size = new Size(422, 23);
            tbxExpenseDesc.TabIndex = 4;
            // 
            // tbxIncome
            // 
            tbxIncome.Location = new Point(98, 125);
            tbxIncome.Name = "tbxIncome";
            tbxIncome.Size = new Size(380, 23);
            tbxIncome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(18, 189);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 2;
            label4.Text = "Expense Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(18, 156);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 1;
            label3.Text = "Expense Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 0;
            label2.Text = "Income:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(12, 339);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 224);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDesc, colAmount });
            dataGridView1.Location = new Point(53, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(577, 142);
            dataGridView1.TabIndex = 0;
            // 
            // colDesc
            // 
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 587);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox tbxExpenseDesc;
        private TextBox tbxIncome;
        private Button btnAddExpenses;
        private Button btnAddIncome;
        private TextBox tbxExpenseAmt;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colAmount;
    }
}
