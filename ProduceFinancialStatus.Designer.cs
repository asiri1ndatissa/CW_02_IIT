
namespace CW_02
{
    partial class ProduceFinancialStatus
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePrediction = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitDate = new System.Windows.Forms.Button();
            this.textBoxExpense = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Prediction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Projected Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projected Expense:";
            // 
            // dateTimePrediction
            // 
            this.dateTimePrediction.Location = new System.Drawing.Point(290, 148);
            this.dateTimePrediction.Name = "dateTimePrediction";
            this.dateTimePrediction.Size = new System.Drawing.Size(200, 20);
            this.dateTimePrediction.TabIndex = 4;
            // 
            // btnSubmitDate
            // 
            this.btnSubmitDate.Location = new System.Drawing.Point(415, 276);
            this.btnSubmitDate.Name = "btnSubmitDate";
            this.btnSubmitDate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitDate.TabIndex = 7;
            this.btnSubmitDate.Text = "Submit";
            this.btnSubmitDate.UseVisualStyleBackColor = true;
            this.btnSubmitDate.Click += new System.EventHandler(this.GeneratePrediction);
            // 
            // textBoxExpense
            // 
            this.textBoxExpense.Location = new System.Drawing.Point(290, 179);
            this.textBoxExpense.Name = "textBoxExpense";
            this.textBoxExpense.Size = new System.Drawing.Size(200, 20);
            this.textBoxExpense.TabIndex = 8;
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(290, 214);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(200, 20);
            this.textBoxIncome.TabIndex = 9;
            // 
            // PredictionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 395);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.textBoxExpense);
            this.Controls.Add(this.btnSubmitDate);
            this.Controls.Add(this.dateTimePrediction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PredictionView";
            this.Text = "PredictionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePrediction;
        private System.Windows.Forms.Button btnSubmitDate;
        private System.Windows.Forms.TextBox textBoxExpense;
        private System.Windows.Forms.TextBox textBoxIncome;
    }
}