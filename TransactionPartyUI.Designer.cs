﻿
namespace CW_02
{
    partial class TransactionPartyUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransactionpartyId = new System.Windows.Forms.TextBox();
            this.txtTransactionPartyName = new System.Windows.Forms.TextBox();
            this.txtTransactionPartyDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Transaction Party";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transaction Party Id:";
            // 
            // txtTransactionpartyId
            // 
            this.txtTransactionpartyId.Location = new System.Drawing.Point(212, 162);
            this.txtTransactionpartyId.Name = "txtTransactionpartyId";
            this.txtTransactionpartyId.Size = new System.Drawing.Size(174, 20);
            this.txtTransactionpartyId.TabIndex = 9;
            // 
            // txtTransactionPartyName
            // 
            this.txtTransactionPartyName.Location = new System.Drawing.Point(212, 204);
            this.txtTransactionPartyName.Name = "txtTransactionPartyName";
            this.txtTransactionPartyName.Size = new System.Drawing.Size(174, 20);
            this.txtTransactionPartyName.TabIndex = 10;
            // 
            // txtTransactionPartyDescription
            // 
            this.txtTransactionPartyDescription.Location = new System.Drawing.Point(212, 245);
            this.txtTransactionPartyDescription.Name = "txtTransactionPartyDescription";
            this.txtTransactionPartyDescription.Size = new System.Drawing.Size(174, 20);
            this.txtTransactionPartyDescription.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(310, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitTransactionParty);
            // 
            // TransactionPartyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTransactionPartyDescription);
            this.Controls.Add(this.txtTransactionPartyName);
            this.Controls.Add(this.txtTransactionpartyId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TransactionPartyUI";
            this.Text = "Transaction Party UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransactionpartyId;
        private System.Windows.Forms.TextBox txtTransactionPartyName;
        private System.Windows.Forms.TextBox txtTransactionPartyDescription;
        private System.Windows.Forms.Button btnSubmit;
    }
}