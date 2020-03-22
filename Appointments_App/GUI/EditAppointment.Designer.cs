namespace Appointments_App.GUI
{
    partial class EditAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAppointment));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.statusShow_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.created_text = new System.Windows.Forms.Label();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.submitComment_button = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.statusShow_label);
            this.titlePanel.Controls.Add(this.status_label);
            this.titlePanel.Controls.Add(this.created_text);
            this.titlePanel.Controls.Add(this.dateCreatedLabel);
            this.titlePanel.Controls.Add(this.title_label);
            this.titlePanel.Location = new System.Drawing.Point(39, 37);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(811, 108);
            this.titlePanel.TabIndex = 0;
            // 
            // statusShow_label
            // 
            this.statusShow_label.AutoSize = true;
            this.statusShow_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusShow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusShow_label.Location = new System.Drawing.Point(692, 67);
            this.statusShow_label.Name = "statusShow_label";
            this.statusShow_label.Size = new System.Drawing.Size(55, 20);
            this.statusShow_label.TabIndex = 5;
            this.statusShow_label.Text = "status";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(608, 67);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(62, 20);
            this.status_label.TabIndex = 4;
            this.status_label.Text = "Status:";
            // 
            // created_text
            // 
            this.created_text.AutoSize = true;
            this.created_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_text.Location = new System.Drawing.Point(136, 67);
            this.created_text.Name = "created_text";
            this.created_text.Size = new System.Drawing.Size(68, 20);
            this.created_text.TabIndex = 3;
            this.created_text.Text = "Created";
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedLabel.Location = new System.Drawing.Point(16, 67);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(114, 20);
            this.dateCreatedLabel.TabIndex = 2;
            this.dateCreatedLabel.Text = "Date Created:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(15, 17);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(61, 29);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            // 
            // submitComment_button
            // 
            this.submitComment_button.BackColor = System.Drawing.Color.White;
            this.submitComment_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitComment_button.BackgroundImage")));
            this.submitComment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitComment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitComment_button.Location = new System.Drawing.Point(808, 293);
            this.submitComment_button.Name = "submitComment_button";
            this.submitComment_button.Size = new System.Drawing.Size(57, 43);
            this.submitComment_button.TabIndex = 9;
            this.submitComment_button.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(85, 293);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(729, 43);
            this.textBox11.TabIndex = 8;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 769);
            this.Controls.Add(this.submitComment_button);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.titlePanel);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.Load += new System.EventHandler(this.EditAppointment_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label statusShow_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label created_text;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button submitComment_button;
        private System.Windows.Forms.TextBox textBox11;
    }
}