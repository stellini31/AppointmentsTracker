namespace Appointments_App.GUI
{
    partial class Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.filter_panel = new System.Windows.Forms.Panel();
            this.reset_Button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.noInt_radio = new System.Windows.Forms.RadioButton();
            this.yesInt_radio = new System.Windows.Forms.RadioButton();
            this.allInt_radio = new System.Windows.Forms.RadioButton();
            this.intermediary_label = new System.Windows.Forms.Label();
            this.created_datetime2 = new System.Windows.Forms.DateTimePicker();
            this.created_datetime1 = new System.Windows.Forms.DateTimePicker();
            this.schedule_datetime2 = new System.Windows.Forms.DateTimePicker();
            this.scheduleDate_combo = new System.Windows.Forms.ComboBox();
            this.createdDate_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.schedule_datetime1 = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.status_label = new System.Windows.Forms.Label();
            this.filter_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filter_panel
            // 
            this.filter_panel.Controls.Add(this.reset_Button);
            this.filter_panel.Controls.Add(this.search_button);
            this.filter_panel.Controls.Add(this.noInt_radio);
            this.filter_panel.Controls.Add(this.yesInt_radio);
            this.filter_panel.Controls.Add(this.allInt_radio);
            this.filter_panel.Controls.Add(this.intermediary_label);
            this.filter_panel.Controls.Add(this.created_datetime2);
            this.filter_panel.Controls.Add(this.created_datetime1);
            this.filter_panel.Controls.Add(this.schedule_datetime2);
            this.filter_panel.Controls.Add(this.scheduleDate_combo);
            this.filter_panel.Controls.Add(this.createdDate_combo);
            this.filter_panel.Controls.Add(this.label1);
            this.filter_panel.Controls.Add(this.type_combo);
            this.filter_panel.Controls.Add(this.type_label);
            this.filter_panel.Controls.Add(this.schedule_datetime1);
            this.filter_panel.Controls.Add(this.date_label);
            this.filter_panel.Controls.Add(this.status_combo);
            this.filter_panel.Controls.Add(this.status_label);
            this.filter_panel.Location = new System.Drawing.Point(6, 10);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(499, 344);
            this.filter_panel.TabIndex = 0;
            // 
            // reset_Button
            // 
            this.reset_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset_Button.BackgroundImage")));
            this.reset_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_Button.FlatAppearance.BorderSize = 0;
            this.reset_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_Button.Location = new System.Drawing.Point(461, 15);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(22, 24);
            this.reset_Button.TabIndex = 18;
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // search_button
            // 
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_button.Location = new System.Drawing.Point(190, 306);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(131, 27);
            this.search_button.TabIndex = 17;
            this.search_button.Text = "Search Criteria";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // noInt_radio
            // 
            this.noInt_radio.AutoSize = true;
            this.noInt_radio.Location = new System.Drawing.Point(266, 266);
            this.noInt_radio.Name = "noInt_radio";
            this.noInt_radio.Size = new System.Drawing.Size(47, 21);
            this.noInt_radio.TabIndex = 16;
            this.noInt_radio.TabStop = true;
            this.noInt_radio.Text = "No";
            this.noInt_radio.UseVisualStyleBackColor = true;
            this.noInt_radio.CheckedChanged += new System.EventHandler(this.noInt_radio_CheckedChanged);
            // 
            // yesInt_radio
            // 
            this.yesInt_radio.AutoSize = true;
            this.yesInt_radio.Location = new System.Drawing.Point(201, 266);
            this.yesInt_radio.Name = "yesInt_radio";
            this.yesInt_radio.Size = new System.Drawing.Size(53, 21);
            this.yesInt_radio.TabIndex = 15;
            this.yesInt_radio.TabStop = true;
            this.yesInt_radio.Text = "Yes";
            this.yesInt_radio.UseVisualStyleBackColor = true;
            this.yesInt_radio.CheckedChanged += new System.EventHandler(this.yesInt_radio_CheckedChanged);
            // 
            // allInt_radio
            // 
            this.allInt_radio.AutoSize = true;
            this.allInt_radio.Location = new System.Drawing.Point(142, 266);
            this.allInt_radio.Name = "allInt_radio";
            this.allInt_radio.Size = new System.Drawing.Size(44, 21);
            this.allInt_radio.TabIndex = 14;
            this.allInt_radio.TabStop = true;
            this.allInt_radio.Text = "All";
            this.allInt_radio.UseVisualStyleBackColor = true;
            this.allInt_radio.CheckedChanged += new System.EventHandler(this.allInt_radio_CheckedChanged);
            // 
            // intermediary_label
            // 
            this.intermediary_label.AutoSize = true;
            this.intermediary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediary_label.Location = new System.Drawing.Point(12, 268);
            this.intermediary_label.Name = "intermediary_label";
            this.intermediary_label.Size = new System.Drawing.Size(127, 17);
            this.intermediary_label.TabIndex = 13;
            this.intermediary_label.Text = "Have Intermediary:";
            // 
            // created_datetime2
            // 
            this.created_datetime2.Enabled = false;
            this.created_datetime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_datetime2.Location = new System.Drawing.Point(319, 222);
            this.created_datetime2.Name = "created_datetime2";
            this.created_datetime2.Size = new System.Drawing.Size(164, 23);
            this.created_datetime2.TabIndex = 12;
            // 
            // created_datetime1
            // 
            this.created_datetime1.Enabled = false;
            this.created_datetime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_datetime1.Location = new System.Drawing.Point(141, 222);
            this.created_datetime1.Name = "created_datetime1";
            this.created_datetime1.Size = new System.Drawing.Size(164, 23);
            this.created_datetime1.TabIndex = 11;
            this.created_datetime1.ValueChanged += new System.EventHandler(this.created_datetime1_ValueChanged);
            // 
            // schedule_datetime2
            // 
            this.schedule_datetime2.Enabled = false;
            this.schedule_datetime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_datetime2.Location = new System.Drawing.Point(319, 99);
            this.schedule_datetime2.Name = "schedule_datetime2";
            this.schedule_datetime2.Size = new System.Drawing.Size(164, 23);
            this.schedule_datetime2.TabIndex = 10;
            // 
            // scheduleDate_combo
            // 
            this.scheduleDate_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scheduleDate_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleDate_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleDate_combo.FormattingEnabled = true;
            this.scheduleDate_combo.Items.AddRange(new object[] {
            "All Dates",
            "On",
            "Before",
            "From",
            "Between"});
            this.scheduleDate_combo.Location = new System.Drawing.Point(141, 59);
            this.scheduleDate_combo.Name = "scheduleDate_combo";
            this.scheduleDate_combo.Size = new System.Drawing.Size(164, 24);
            this.scheduleDate_combo.TabIndex = 9;
            this.scheduleDate_combo.SelectedIndexChanged += new System.EventHandler(this.statusDate_combo_SelectedIndexChanged);
            // 
            // createdDate_combo
            // 
            this.createdDate_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createdDate_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createdDate_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDate_combo.FormattingEnabled = true;
            this.createdDate_combo.Items.AddRange(new object[] {
            "All Dates",
            "On",
            "Before",
            "From",
            "Between"});
            this.createdDate_combo.Location = new System.Drawing.Point(141, 183);
            this.createdDate_combo.Name = "createdDate_combo";
            this.createdDate_combo.Size = new System.Drawing.Size(164, 24);
            this.createdDate_combo.TabIndex = 8;
            this.createdDate_combo.SelectedIndexChanged += new System.EventHandler(this.createdDate_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date created:";
            // 
            // type_combo
            // 
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(141, 140);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(164, 24);
            this.type_combo.TabIndex = 5;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(12, 143);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(44, 17);
            this.type_label.TabIndex = 4;
            this.type_label.Text = "Type:";
            // 
            // schedule_datetime1
            // 
            this.schedule_datetime1.Enabled = false;
            this.schedule_datetime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_datetime1.Location = new System.Drawing.Point(141, 99);
            this.schedule_datetime1.Name = "schedule_datetime1";
            this.schedule_datetime1.Size = new System.Drawing.Size(164, 23);
            this.schedule_datetime1.TabIndex = 3;
            this.schedule_datetime1.ValueChanged += new System.EventHandler(this.schedule_datetime1_ValueChanged);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(12, 62);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(105, 17);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "Schedule Date:";
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "All",
            "Done",
            "In Progress"});
            this.status_combo.Location = new System.Drawing.Point(141, 12);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(164, 24);
            this.status_combo.TabIndex = 1;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(12, 15);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(52, 17);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "Status:";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 362);
            this.Controls.Add(this.filter_panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 413);
            this.MinimumSize = new System.Drawing.Size(534, 413);
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.filter_panel.ResumeLayout(false);
            this.filter_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.DateTimePicker schedule_datetime1;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scheduleDate_combo;
        private System.Windows.Forms.ComboBox createdDate_combo;
        private System.Windows.Forms.DateTimePicker created_datetime2;
        private System.Windows.Forms.DateTimePicker created_datetime1;
        private System.Windows.Forms.DateTimePicker schedule_datetime2;
        private System.Windows.Forms.RadioButton noInt_radio;
        private System.Windows.Forms.RadioButton yesInt_radio;
        private System.Windows.Forms.RadioButton allInt_radio;
        private System.Windows.Forms.Label intermediary_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button reset_Button;
    }
}