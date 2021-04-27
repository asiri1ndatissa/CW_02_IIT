
namespace CW_02
{
    partial class EventUI
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
            this.bnEnterEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnEnterEvent
            // 
            this.bnEnterEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bnEnterEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEnterEvent.Location = new System.Drawing.Point(69, 74);
            this.bnEnterEvent.Name = "bnEnterEvent";
            this.bnEnterEvent.Size = new System.Drawing.Size(185, 47);
            this.bnEnterEvent.TabIndex = 1;
            this.bnEnterEvent.Text = "Enter an Event";
            this.bnEnterEvent.UseVisualStyleBackColor = false;
            this.bnEnterEvent.Click += new System.EventHandler(this.ShowEntryEventView);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(69, 147);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(185, 47);
            this.btnUpdateEvent.TabIndex = 2;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.ShowUpdateEntryView);
            // 
            // EventUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.bnEnterEvent);
            this.Name = "EventUI";
            this.Text = "EventUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnEnterEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
    }
}