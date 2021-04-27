
namespace CW_02
{
    partial class MainMenu
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
            this.bnManageTransaction = new System.Windows.Forms.Button();
            this.btnManageTransactionParty = new System.Windows.Forms.Button();
            this.btnProduceReports = new System.Windows.Forms.Button();
            this.btnPrediction = new System.Windows.Forms.Button();
            this.btnManageEvent = new System.Windows.Forms.Button();
            this.btnWeeklyView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnManageTransaction
            // 
            this.bnManageTransaction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bnManageTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnManageTransaction.Location = new System.Drawing.Point(100, 56);
            this.bnManageTransaction.Name = "bnManageTransaction";
            this.bnManageTransaction.Size = new System.Drawing.Size(185, 47);
            this.bnManageTransaction.TabIndex = 0;
            this.bnManageTransaction.Text = "Manage Transaction";
            this.bnManageTransaction.UseVisualStyleBackColor = false;
            this.bnManageTransaction.Click += new System.EventHandler(this.ShowManageTransactionView);
            // 
            // btnManageTransactionParty
            // 
            this.btnManageTransactionParty.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManageTransactionParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTransactionParty.Location = new System.Drawing.Point(100, 118);
            this.btnManageTransactionParty.Name = "btnManageTransactionParty";
            this.btnManageTransactionParty.Size = new System.Drawing.Size(185, 47);
            this.btnManageTransactionParty.TabIndex = 1;
            this.btnManageTransactionParty.Text = "Manage Transaction Party";
            this.btnManageTransactionParty.UseVisualStyleBackColor = false;
            this.btnManageTransactionParty.Click += new System.EventHandler(this.ShowManageTransactionPartyView);
            // 
            // btnProduceReports
            // 
            this.btnProduceReports.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnProduceReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceReports.Location = new System.Drawing.Point(100, 185);
            this.btnProduceReports.Name = "btnProduceReports";
            this.btnProduceReports.Size = new System.Drawing.Size(185, 47);
            this.btnProduceReports.TabIndex = 2;
            this.btnProduceReports.Text = "Produce Reports";
            this.btnProduceReports.UseVisualStyleBackColor = false;
            this.btnProduceReports.Click += new System.EventHandler(this.ShowProduceReportView);
            // 
            // btnPrediction
            // 
            this.btnPrediction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrediction.Location = new System.Drawing.Point(100, 253);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(185, 47);
            this.btnPrediction.TabIndex = 3;
            this.btnPrediction.Text = "Prediction";
            this.btnPrediction.UseVisualStyleBackColor = false;
            this.btnPrediction.Click += new System.EventHandler(this.ShowPrediction);
            // 
            // btnManageEvent
            // 
            this.btnManageEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManageEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEvent.Location = new System.Drawing.Point(100, 315);
            this.btnManageEvent.Name = "btnManageEvent";
            this.btnManageEvent.Size = new System.Drawing.Size(185, 47);
            this.btnManageEvent.TabIndex = 4;
            this.btnManageEvent.Text = "Manage an Event";
            this.btnManageEvent.UseVisualStyleBackColor = false;
            this.btnManageEvent.Click += new System.EventHandler(this.LoadManageEventView);
            // 
            // btnWeeklyView
            // 
            this.btnWeeklyView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnWeeklyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyView.Location = new System.Drawing.Point(100, 380);
            this.btnWeeklyView.Name = "btnWeeklyView";
            this.btnWeeklyView.Size = new System.Drawing.Size(185, 47);
            this.btnWeeklyView.TabIndex = 5;
            this.btnWeeklyView.Text = "Weekly View";
            this.btnWeeklyView.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 494);
            this.Controls.Add(this.btnWeeklyView);
            this.Controls.Add(this.btnManageEvent);
            this.Controls.Add(this.btnPrediction);
            this.Controls.Add(this.btnProduceReports);
            this.Controls.Add(this.btnManageTransactionParty);
            this.Controls.Add(this.bnManageTransaction);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnManageTransaction;
        private System.Windows.Forms.Button btnManageTransactionParty;
        private System.Windows.Forms.Button btnProduceReports;
        private System.Windows.Forms.Button btnPrediction;
        private System.Windows.Forms.Button btnManageEvent;
        private System.Windows.Forms.Button btnWeeklyView;
    }
}

