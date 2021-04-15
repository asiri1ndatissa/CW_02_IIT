
namespace CW_02
{
    partial class TransactionUI
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
            this.btnEnterTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterTransaction
            // 
            this.btnEnterTransaction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnterTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterTransaction.Location = new System.Drawing.Point(90, 100);
            this.btnEnterTransaction.Name = "btnEnterTransaction";
            this.btnEnterTransaction.Size = new System.Drawing.Size(235, 51);
            this.btnEnterTransaction.TabIndex = 0;
            this.btnEnterTransaction.Text = "Enter New Transaction";
            this.btnEnterTransaction.UseVisualStyleBackColor = false;
            this.btnEnterTransaction.Click += new System.EventHandler(this.ShowTransactionEntryView);
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTransaction.Location = new System.Drawing.Point(90, 170);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(235, 51);
            this.btnEditTransaction.TabIndex = 1;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = false;
            this.btnEditTransaction.Click += new System.EventHandler(this.ShowEditTransactionView);
            // 
            // TransactionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditTransaction);
            this.Controls.Add(this.btnEnterTransaction);
            this.Name = "TransactionUI";
            this.Text = "Transaction UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterTransaction;
        private System.Windows.Forms.Button btnEditTransaction;
    }
}