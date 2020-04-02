namespace Appointments_App.GUI
{
    partial class Reminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminders));
            this.reminders_panel = new System.Windows.Forms.Panel();
            this.dismissall_label = new System.Windows.Forms.LinkLabel();
            this.reminders_label = new System.Windows.Forms.Label();
            this.reminders_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminders_panel
            // 
            this.reminders_panel.AutoScroll = true;
            this.reminders_panel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.reminders_panel.Controls.Add(this.dismissall_label);
            this.reminders_panel.Controls.Add(this.reminders_label);
            this.reminders_panel.Location = new System.Drawing.Point(7, 6);
            this.reminders_panel.Name = "reminders_panel";
            this.reminders_panel.Size = new System.Drawing.Size(1108, 404);
            this.reminders_panel.TabIndex = 0;
            // 
            // dismissall_label
            // 
            this.dismissall_label.AutoSize = true;
            this.dismissall_label.Location = new System.Drawing.Point(898, 27);
            this.dismissall_label.Name = "dismissall_label";
            this.dismissall_label.Size = new System.Drawing.Size(72, 17);
            this.dismissall_label.TabIndex = 19;
            this.dismissall_label.TabStop = true;
            this.dismissall_label.Text = "dismiss all";
            this.dismissall_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dismissall_label_LinkClicked);
            // 
            // reminders_label
            // 
            this.reminders_label.AutoSize = true;
            this.reminders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminders_label.Location = new System.Drawing.Point(10, 15);
            this.reminders_label.Name = "reminders_label";
            this.reminders_label.Size = new System.Drawing.Size(221, 29);
            this.reminders_label.TabIndex = 18;
            this.reminders_label.Text = "Today\'s Reminders";
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1127, 415);
            this.Controls.Add(this.reminders_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reminders";
            this.Load += new System.EventHandler(this.Reminders_Load);
            this.reminders_panel.ResumeLayout(false);
            this.reminders_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reminders_panel;
        private System.Windows.Forms.Label reminders_label;
        private System.Windows.Forms.LinkLabel dismissall_label;
    }
}