namespace Appointments_App.GUI
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.addAppointmentType_panel = new System.Windows.Forms.Panel();
            this.appointmentTypes_label = new System.Windows.Forms.Label();
            this.visibleAppTypes_list = new System.Windows.Forms.ListBox();
            this.notvisibleAppTypes_list = new System.Windows.Forms.ListBox();
            this.visible_label = new System.Windows.Forms.Label();
            this.noyVisible_label = new System.Windows.Forms.Label();
            this.moveToHidden = new System.Windows.Forms.Button();
            this.moveAllToVisible_button = new System.Windows.Forms.Button();
            this.moveToVisible_button = new System.Windows.Forms.Button();
            this.appType_text = new System.Windows.Forms.TextBox();
            this.addType_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.hideError_label = new System.Windows.Forms.Timer(this.components);
            this.addAppointmentType_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAppointmentType_panel
            // 
            this.addAppointmentType_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAppointmentType_panel.Controls.Add(this.error_label);
            this.addAppointmentType_panel.Controls.Add(this.addType_button);
            this.addAppointmentType_panel.Controls.Add(this.appType_text);
            this.addAppointmentType_panel.Controls.Add(this.moveToVisible_button);
            this.addAppointmentType_panel.Controls.Add(this.moveAllToVisible_button);
            this.addAppointmentType_panel.Controls.Add(this.moveToHidden);
            this.addAppointmentType_panel.Controls.Add(this.noyVisible_label);
            this.addAppointmentType_panel.Controls.Add(this.visible_label);
            this.addAppointmentType_panel.Controls.Add(this.notvisibleAppTypes_list);
            this.addAppointmentType_panel.Controls.Add(this.visibleAppTypes_list);
            this.addAppointmentType_panel.Location = new System.Drawing.Point(17, 30);
            this.addAppointmentType_panel.Name = "addAppointmentType_panel";
            this.addAppointmentType_panel.Size = new System.Drawing.Size(520, 326);
            this.addAppointmentType_panel.TabIndex = 0;
            // 
            // appointmentTypes_label
            // 
            this.appointmentTypes_label.AutoSize = true;
            this.appointmentTypes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypes_label.Location = new System.Drawing.Point(38, 16);
            this.appointmentTypes_label.Name = "appointmentTypes_label";
            this.appointmentTypes_label.Size = new System.Drawing.Size(182, 25);
            this.appointmentTypes_label.TabIndex = 0;
            this.appointmentTypes_label.Text = "Appointment Types";
            // 
            // visibleAppTypes_list
            // 
            this.visibleAppTypes_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibleAppTypes_list.FormattingEnabled = true;
            this.visibleAppTypes_list.ItemHeight = 20;
            this.visibleAppTypes_list.Location = new System.Drawing.Point(35, 68);
            this.visibleAppTypes_list.Name = "visibleAppTypes_list";
            this.visibleAppTypes_list.Size = new System.Drawing.Size(188, 184);
            this.visibleAppTypes_list.TabIndex = 2;
            // 
            // notvisibleAppTypes_list
            // 
            this.notvisibleAppTypes_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notvisibleAppTypes_list.FormattingEnabled = true;
            this.notvisibleAppTypes_list.ItemHeight = 20;
            this.notvisibleAppTypes_list.Location = new System.Drawing.Point(296, 68);
            this.notvisibleAppTypes_list.Name = "notvisibleAppTypes_list";
            this.notvisibleAppTypes_list.Size = new System.Drawing.Size(188, 184);
            this.notvisibleAppTypes_list.TabIndex = 3;
            // 
            // visible_label
            // 
            this.visible_label.AutoSize = true;
            this.visible_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visible_label.Location = new System.Drawing.Point(31, 36);
            this.visible_label.Name = "visible_label";
            this.visible_label.Size = new System.Drawing.Size(68, 20);
            this.visible_label.TabIndex = 1;
            this.visible_label.Text = "Enabled";
            // 
            // noyVisible_label
            // 
            this.noyVisible_label.AutoSize = true;
            this.noyVisible_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noyVisible_label.Location = new System.Drawing.Point(292, 36);
            this.noyVisible_label.Name = "noyVisible_label";
            this.noyVisible_label.Size = new System.Drawing.Size(71, 20);
            this.noyVisible_label.TabIndex = 4;
            this.noyVisible_label.Text = "Disabled";
            // 
            // moveToHidden
            // 
            this.moveToHidden.BackColor = System.Drawing.Color.Transparent;
            this.moveToHidden.FlatAppearance.BorderSize = 0;
            this.moveToHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveToHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToHidden.Location = new System.Drawing.Point(243, 214);
            this.moveToHidden.Name = "moveToHidden";
            this.moveToHidden.Size = new System.Drawing.Size(34, 38);
            this.moveToHidden.TabIndex = 5;
            this.moveToHidden.Text = ">";
            this.moveToHidden.UseVisualStyleBackColor = false;
            this.moveToHidden.Click += new System.EventHandler(this.selectNotVisible_buton_Click);
            // 
            // moveAllToVisible_button
            // 
            this.moveAllToVisible_button.FlatAppearance.BorderSize = 0;
            this.moveAllToVisible_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveAllToVisible_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveAllToVisible_button.Location = new System.Drawing.Point(229, 68);
            this.moveAllToVisible_button.Name = "moveAllToVisible_button";
            this.moveAllToVisible_button.Size = new System.Drawing.Size(62, 47);
            this.moveAllToVisible_button.TabIndex = 6;
            this.moveAllToVisible_button.Text = "<<";
            this.moveAllToVisible_button.UseVisualStyleBackColor = true;
            this.moveAllToVisible_button.Click += new System.EventHandler(this.moveAllToVisible_button_Click);
            // 
            // moveToVisible_button
            // 
            this.moveToVisible_button.FlatAppearance.BorderSize = 0;
            this.moveToVisible_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveToVisible_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToVisible_button.Location = new System.Drawing.Point(243, 101);
            this.moveToVisible_button.Name = "moveToVisible_button";
            this.moveToVisible_button.Size = new System.Drawing.Size(34, 38);
            this.moveToVisible_button.TabIndex = 7;
            this.moveToVisible_button.Text = "<";
            this.moveToVisible_button.UseVisualStyleBackColor = true;
            this.moveToVisible_button.Click += new System.EventHandler(this.moveToVisible_button_Click);
            // 
            // appType_text
            // 
            this.appType_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appType_text.Location = new System.Drawing.Point(35, 269);
            this.appType_text.Name = "appType_text";
            this.appType_text.Size = new System.Drawing.Size(422, 26);
            this.appType_text.TabIndex = 8;
            // 
            // addType_button
            // 
            this.addType_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addType_button.BackgroundImage")));
            this.addType_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addType_button.FlatAppearance.BorderSize = 0;
            this.addType_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addType_button.Location = new System.Drawing.Point(463, 269);
            this.addType_button.Name = "addType_button";
            this.addType_button.Size = new System.Drawing.Size(24, 25);
            this.addType_button.TabIndex = 9;
            this.addType_button.UseVisualStyleBackColor = true;
            this.addType_button.Click += new System.EventHandler(this.addType_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.LightCoral;
            this.error_label.Location = new System.Drawing.Point(31, 298);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(53, 20);
            this.error_label.TabIndex = 10;
            this.error_label.Text = "label1";
            this.error_label.Visible = false;
            // 
            // hideError_label
            // 
            this.hideError_label.Tick += new System.EventHandler(this.hideError_label_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 543);
            this.Controls.Add(this.appointmentTypes_label);
            this.Controls.Add(this.addAppointmentType_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.addAppointmentType_panel.ResumeLayout(false);
            this.addAppointmentType_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel addAppointmentType_panel;
        private System.Windows.Forms.Label appointmentTypes_label;
        private System.Windows.Forms.ListBox visibleAppTypes_list;
        private System.Windows.Forms.Button moveToVisible_button;
        private System.Windows.Forms.Button moveAllToVisible_button;
        private System.Windows.Forms.Button moveToHidden;
        private System.Windows.Forms.Label noyVisible_label;
        private System.Windows.Forms.Label visible_label;
        private System.Windows.Forms.ListBox notvisibleAppTypes_list;
        private System.Windows.Forms.Button addType_button;
        private System.Windows.Forms.TextBox appType_text;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Timer hideError_label;
    }
}