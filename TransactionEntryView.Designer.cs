﻿
namespace CW_02
{
    partial class TransactionEntryView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmBoxType = new System.Windows.Forms.ComboBox();
            this.cmbBoxRecurrent = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.btnShowDataGrid = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Entry View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recurrent/OneOff :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type (income/expense):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transaction Party Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date :";
            // 
            // dateTransaction
            // 
            this.dateTransaction.CustomFormat = "yyyy-MM-dd";
            this.dateTransaction.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTransaction.Location = new System.Drawing.Point(300, 140);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(93, 20);
            this.dateTransaction.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(249, 248);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 20);
            this.txtAmount.TabIndex = 12;
            // 
            // cmBoxType
            // 
            this.cmBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxType.FormattingEnabled = true;
            this.cmBoxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmBoxType.Location = new System.Drawing.Point(250, 194);
            this.cmBoxType.Name = "cmBoxType";
            this.cmBoxType.Size = new System.Drawing.Size(144, 21);
            this.cmBoxType.TabIndex = 13;
            // 
            // cmbBoxRecurrent
            // 
            this.cmbBoxRecurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRecurrent.FormattingEnabled = true;
            this.cmbBoxRecurrent.Items.AddRange(new object[] {
            "Recurrent",
            "Oneoff"});
            this.cmbBoxRecurrent.Location = new System.Drawing.Point(250, 221);
            this.cmbBoxRecurrent.Name = "cmbBoxRecurrent";
            this.cmbBoxRecurrent.Size = new System.Drawing.Size(143, 21);
            this.cmbBoxRecurrent.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(302, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 29);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitTransactionEntry);
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbId.Location = new System.Drawing.Point(250, 167);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(143, 21);
            this.cmbId.TabIndex = 16;
            // 
            // btnShowDataGrid
            // 
            this.btnShowDataGrid.Location = new System.Drawing.Point(71, 330);
            this.btnShowDataGrid.Name = "btnShowDataGrid";
            this.btnShowDataGrid.Size = new System.Drawing.Size(75, 23);
            this.btnShowDataGrid.TabIndex = 18;
            this.btnShowDataGrid.Text = "button1";
            this.btnShowDataGrid.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // TransactionEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowDataGrid);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbBoxRecurrent);
            this.Controls.Add(this.cmBoxType);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dateTransaction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TransactionEntryView";
            this.Text = "Transaction Entry View";
            this.Load += new System.EventHandler(this.TransactionEntryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmBoxType;
        private System.Windows.Forms.ComboBox cmbBoxRecurrent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Button btnShowDataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}