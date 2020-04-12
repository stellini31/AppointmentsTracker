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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAppointment));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.print_button = new System.Windows.Forms.Button();
            this.saved_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.statusShow_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.parent_link = new System.Windows.Forms.LinkLabel();
            this.parent_label = new System.Windows.Forms.Label();
            this.followup_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.created_text = new System.Windows.Forms.Label();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.required_tel = new System.Windows.Forms.Label();
            this.required_surname = new System.Windows.Forms.Label();
            this.required_name = new System.Windows.Forms.Label();
            this.required_id = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.tel2_text = new System.Windows.Forms.TextBox();
            this.surname2_text = new System.Windows.Forms.TextBox();
            this.name2_text = new System.Windows.Forms.TextBox();
            this.id2_text = new System.Windows.Forms.TextBox();
            this.addPerson_check = new System.Windows.Forms.CheckBox();
            this.tel1_text = new System.Windows.Forms.TextBox();
            this.surname1_text = new System.Windows.Forms.TextBox();
            this.name1_text = new System.Windows.Forms.TextBox();
            this.id1_text = new System.Windows.Forms.TextBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.personal_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Label();
            this.intermediary_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.types_combo = new System.Windows.Forms.ComboBox();
            this.intermediary_text = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.appInfo_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comment_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commentsubmit_text = new System.Windows.Forms.TextBox();
            this.submitComment_button = new System.Windows.Forms.Button();
            this.followup_panel = new System.Windows.Forms.Panel();
            this.followsupItems_panel = new System.Windows.Forms.Panel();
            this.followup_label = new System.Windows.Forms.Label();
            this.hide_success_label = new System.Windows.Forms.Timer(this.components);
            this.hide_error_label = new System.Windows.Forms.Timer(this.components);
            this.allReminders_panel = new System.Windows.Forms.Panel();
            this.upcomingRem_labe = new System.Windows.Forms.Label();
            this.reminders_panel = new System.Windows.Forms.Panel();
            this.addRrem_button = new System.Windows.Forms.Button();
            this.setReminder_panel = new System.Windows.Forms.Panel();
            this.remMessage_text = new System.Windows.Forms.TextBox();
            this.remMessage_label = new System.Windows.Forms.Label();
            this.reminder_datetime = new System.Windows.Forms.DateTimePicker();
            this.reminderDate_label = new System.Windows.Forms.Label();
            this.reminders_label = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.titlePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.followup_panel.SuspendLayout();
            this.allReminders_panel.SuspendLayout();
            this.setReminder_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Transparent;
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.print_button);
            this.titlePanel.Controls.Add(this.saved_label);
            this.titlePanel.Controls.Add(this.save_button);
            this.titlePanel.Controls.Add(this.statusShow_label);
            this.titlePanel.Controls.Add(this.close_button);
            this.titlePanel.Controls.Add(this.parent_link);
            this.titlePanel.Controls.Add(this.parent_label);
            this.titlePanel.Controls.Add(this.followup_button);
            this.titlePanel.Controls.Add(this.status_label);
            this.titlePanel.Controls.Add(this.created_text);
            this.titlePanel.Controls.Add(this.dateCreatedLabel);
            this.titlePanel.Controls.Add(this.title_label);
            this.titlePanel.Location = new System.Drawing.Point(12, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(843, 108);
            this.titlePanel.TabIndex = 0;
            // 
            // print_button
            // 
            this.print_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_button.BackgroundImage")));
            this.print_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_button.FlatAppearance.BorderSize = 0;
            this.print_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_button.Location = new System.Drawing.Point(812, -1);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(30, 30);
            this.print_button.TabIndex = 21;
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // saved_label
            // 
            this.saved_label.AutoSize = true;
            this.saved_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.saved_label.Location = new System.Drawing.Point(758, 86);
            this.saved_label.Name = "saved_label";
            this.saved_label.Size = new System.Drawing.Size(60, 18);
            this.saved_label.TabIndex = 20;
            this.saved_label.Text = "SAVED!";
            this.saved_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.Location = new System.Drawing.Point(764, 35);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(51, 52);
            this.save_button.TabIndex = 12;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // statusShow_label
            // 
            this.statusShow_label.AutoSize = true;
            this.statusShow_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusShow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusShow_label.Location = new System.Drawing.Point(97, 62);
            this.statusShow_label.Name = "statusShow_label";
            this.statusShow_label.Size = new System.Drawing.Size(64, 25);
            this.statusShow_label.TabIndex = 5;
            this.statusShow_label.Text = "status";
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(226, 58);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(56, 38);
            this.close_button.TabIndex = 11;
            this.close_button.Text = "close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // parent_link
            // 
            this.parent_link.AutoSize = true;
            this.parent_link.Location = new System.Drawing.Point(569, 28);
            this.parent_link.Name = "parent_link";
            this.parent_link.Size = new System.Drawing.Size(72, 17);
            this.parent_link.TabIndex = 10;
            this.parent_link.TabStop = true;
            this.parent_link.Text = "linkLabel1";
            this.parent_link.Visible = false;
            this.parent_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.parent_link_LinkClicked);
            // 
            // parent_label
            // 
            this.parent_label.AutoSize = true;
            this.parent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_label.Location = new System.Drawing.Point(478, 26);
            this.parent_label.Name = "parent_label";
            this.parent_label.Size = new System.Drawing.Size(85, 20);
            this.parent_label.TabIndex = 9;
            this.parent_label.Text = "Parent ID:";
            this.parent_label.Visible = false;
            // 
            // followup_button
            // 
            this.followup_button.BackColor = System.Drawing.Color.Transparent;
            this.followup_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("followup_button.BackgroundImage")));
            this.followup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.followup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.followup_button.FlatAppearance.BorderSize = 0;
            this.followup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.followup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followup_button.Location = new System.Drawing.Point(686, 35);
            this.followup_button.Name = "followup_button";
            this.followup_button.Size = new System.Drawing.Size(57, 52);
            this.followup_button.TabIndex = 8;
            this.followup_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.followup_button.UseVisualStyleBackColor = false;
            this.followup_button.Visible = false;
            this.followup_button.Click += new System.EventHandler(this.followup_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(15, 62);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(74, 25);
            this.status_label.TabIndex = 4;
            this.status_label.Text = "Status:";
            // 
            // created_text
            // 
            this.created_text.AutoSize = true;
            this.created_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_text.Location = new System.Drawing.Point(568, 67);
            this.created_text.Name = "created_text";
            this.created_text.Size = new System.Drawing.Size(68, 20);
            this.created_text.TabIndex = 3;
            this.created_text.Text = "Created";
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedLabel.Location = new System.Drawing.Point(448, 66);
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
            this.title_label.MaximumSize = new System.Drawing.Size(350, 29);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(61, 29);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.required_tel);
            this.panel2.Controls.Add(this.required_surname);
            this.panel2.Controls.Add(this.required_name);
            this.panel2.Controls.Add(this.required_id);
            this.panel2.Controls.Add(this.error_label);
            this.panel2.Controls.Add(this.tel2_text);
            this.panel2.Controls.Add(this.surname2_text);
            this.panel2.Controls.Add(this.name2_text);
            this.panel2.Controls.Add(this.id2_text);
            this.panel2.Controls.Add(this.addPerson_check);
            this.panel2.Controls.Add(this.tel1_text);
            this.panel2.Controls.Add(this.surname1_text);
            this.panel2.Controls.Add(this.name1_text);
            this.panel2.Controls.Add(this.id1_text);
            this.panel2.Controls.Add(this.tel_label);
            this.panel2.Controls.Add(this.personal_label);
            this.panel2.Controls.Add(this.surname_label);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Controls.Add(this.id_text);
            this.panel2.Location = new System.Drawing.Point(12, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 262);
            this.panel2.TabIndex = 10;
            // 
            // required_tel
            // 
            this.required_tel.AutoSize = true;
            this.required_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_tel.ForeColor = System.Drawing.Color.Red;
            this.required_tel.Location = new System.Drawing.Point(427, 168);
            this.required_tel.Name = "required_tel";
            this.required_tel.Size = new System.Drawing.Size(20, 25);
            this.required_tel.TabIndex = 25;
            this.required_tel.Text = "*";
            this.required_tel.Visible = false;
            // 
            // required_surname
            // 
            this.required_surname.AutoSize = true;
            this.required_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_surname.ForeColor = System.Drawing.Color.Red;
            this.required_surname.Location = new System.Drawing.Point(427, 130);
            this.required_surname.Name = "required_surname";
            this.required_surname.Size = new System.Drawing.Size(20, 25);
            this.required_surname.TabIndex = 24;
            this.required_surname.Text = "*";
            this.required_surname.Visible = false;
            // 
            // required_name
            // 
            this.required_name.AutoSize = true;
            this.required_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_name.ForeColor = System.Drawing.Color.Red;
            this.required_name.Location = new System.Drawing.Point(427, 94);
            this.required_name.Name = "required_name";
            this.required_name.Size = new System.Drawing.Size(20, 25);
            this.required_name.TabIndex = 23;
            this.required_name.Text = "*";
            this.required_name.Visible = false;
            // 
            // required_id
            // 
            this.required_id.AutoSize = true;
            this.required_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_id.ForeColor = System.Drawing.Color.Red;
            this.required_id.Location = new System.Drawing.Point(427, 57);
            this.required_id.Name = "required_id";
            this.required_id.Size = new System.Drawing.Size(20, 25);
            this.required_id.TabIndex = 22;
            this.required_id.Text = "*";
            this.required_id.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.LightCoral;
            this.error_label.Location = new System.Drawing.Point(500, 19);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(304, 18);
            this.error_label.TabIndex = 21;
            this.error_label.Text = "CANNOT LEAVE REQUIRD FIELDS EMPTY";
            this.error_label.Visible = false;
            // 
            // tel2_text
            // 
            this.tel2_text.Enabled = false;
            this.tel2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel2_text.Location = new System.Drawing.Point(510, 163);
            this.tel2_text.Name = "tel2_text";
            this.tel2_text.Size = new System.Drawing.Size(294, 30);
            this.tel2_text.TabIndex = 16;
            // 
            // surname2_text
            // 
            this.surname2_text.Enabled = false;
            this.surname2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname2_text.Location = new System.Drawing.Point(510, 125);
            this.surname2_text.Name = "surname2_text";
            this.surname2_text.Size = new System.Drawing.Size(294, 30);
            this.surname2_text.TabIndex = 15;
            // 
            // name2_text
            // 
            this.name2_text.Enabled = false;
            this.name2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2_text.Location = new System.Drawing.Point(510, 89);
            this.name2_text.Name = "name2_text";
            this.name2_text.Size = new System.Drawing.Size(294, 30);
            this.name2_text.TabIndex = 14;
            // 
            // id2_text
            // 
            this.id2_text.Enabled = false;
            this.id2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id2_text.Location = new System.Drawing.Point(510, 52);
            this.id2_text.Name = "id2_text";
            this.id2_text.Size = new System.Drawing.Size(294, 30);
            this.id2_text.TabIndex = 13;
            // 
            // addPerson_check
            // 
            this.addPerson_check.AutoSize = true;
            this.addPerson_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPerson_check.Location = new System.Drawing.Point(3, 215);
            this.addPerson_check.Name = "addPerson_check";
            this.addPerson_check.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addPerson_check.Size = new System.Drawing.Size(143, 29);
            this.addPerson_check.TabIndex = 12;
            this.addPerson_check.Text = ":Add Person";
            this.addPerson_check.UseVisualStyleBackColor = true;
            this.addPerson_check.CheckedChanged += new System.EventHandler(this.addPerson_check_CheckedChanged);
            // 
            // tel1_text
            // 
            this.tel1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel1_text.Location = new System.Drawing.Point(130, 163);
            this.tel1_text.Name = "tel1_text";
            this.tel1_text.Size = new System.Drawing.Size(294, 30);
            this.tel1_text.TabIndex = 10;
            // 
            // surname1_text
            // 
            this.surname1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname1_text.Location = new System.Drawing.Point(130, 125);
            this.surname1_text.Name = "surname1_text";
            this.surname1_text.Size = new System.Drawing.Size(294, 30);
            this.surname1_text.TabIndex = 9;
            // 
            // name1_text
            // 
            this.name1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1_text.Location = new System.Drawing.Point(130, 89);
            this.name1_text.Name = "name1_text";
            this.name1_text.Size = new System.Drawing.Size(294, 30);
            this.name1_text.TabIndex = 8;
            // 
            // id1_text
            // 
            this.id1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1_text.Location = new System.Drawing.Point(130, 52);
            this.id1_text.Name = "id1_text";
            this.id1_text.Size = new System.Drawing.Size(294, 30);
            this.id1_text.TabIndex = 7;
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_label.Location = new System.Drawing.Point(12, 166);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(112, 25);
            this.tel_label.TabIndex = 5;
            this.tel_label.Text = "Telephone:";
            // 
            // personal_label
            // 
            this.personal_label.AutoSize = true;
            this.personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_label.Location = new System.Drawing.Point(12, 11);
            this.personal_label.Name = "personal_label";
            this.personal_label.Size = new System.Drawing.Size(234, 29);
            this.personal_label.TabIndex = 4;
            this.personal_label.Text = "Personal Information";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_label.Location = new System.Drawing.Point(26, 128);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(98, 25);
            this.surname_label.TabIndex = 3;
            this.surname_label.Text = "Surname:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(54, 92);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 25);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name:";
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_text.Location = new System.Drawing.Point(87, 52);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(37, 25);
            this.id_text.TabIndex = 1;
            this.id_text.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.time_label);
            this.panel4.Controls.Add(this.intermediary_label);
            this.panel4.Controls.Add(this.type_label);
            this.panel4.Controls.Add(this.date_label);
            this.panel4.Controls.Add(this.types_combo);
            this.panel4.Controls.Add(this.intermediary_text);
            this.panel4.Controls.Add(this.datePicker);
            this.panel4.Controls.Add(this.timePicker);
            this.panel4.Controls.Add(this.appInfo_label);
            this.panel4.Location = new System.Drawing.Point(12, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 254);
            this.panel4.TabIndex = 19;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(18, 112);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(177, 25);
            this.time_label.TabIndex = 28;
            this.time_label.Text = "Appointment Time:";
            // 
            // intermediary_label
            // 
            this.intermediary_label.AutoSize = true;
            this.intermediary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediary_label.Location = new System.Drawing.Point(70, 200);
            this.intermediary_label.Name = "intermediary_label";
            this.intermediary_label.Size = new System.Drawing.Size(125, 25);
            this.intermediary_label.TabIndex = 24;
            this.intermediary_label.Text = "Intermediary:";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(17, 157);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(178, 25);
            this.type_label.TabIndex = 23;
            this.type_label.Text = "Appointment Type:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(21, 65);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(174, 25);
            this.date_label.TabIndex = 22;
            this.date_label.Text = "Appointment Date:";
            // 
            // types_combo
            // 
            this.types_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.types_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types_combo.FormattingEnabled = true;
            this.types_combo.Location = new System.Drawing.Point(217, 154);
            this.types_combo.Name = "types_combo";
            this.types_combo.Size = new System.Drawing.Size(219, 33);
            this.types_combo.TabIndex = 26;
            // 
            // intermediary_text
            // 
            this.intermediary_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediary_text.Location = new System.Drawing.Point(217, 200);
            this.intermediary_text.Name = "intermediary_text";
            this.intermediary_text.Size = new System.Drawing.Size(219, 30);
            this.intermediary_text.TabIndex = 25;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(217, 65);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(219, 30);
            this.datePicker.TabIndex = 21;
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(217, 107);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(219, 30);
            this.timePicker.TabIndex = 27;
            // 
            // appInfo_label
            // 
            this.appInfo_label.AutoSize = true;
            this.appInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appInfo_label.Location = new System.Drawing.Point(12, 10);
            this.appInfo_label.Name = "appInfo_label";
            this.appInfo_label.Size = new System.Drawing.Size(273, 29);
            this.appInfo_label.TabIndex = 17;
            this.appInfo_label.Text = "Appointment Information";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comment_text);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.commentsubmit_text);
            this.panel3.Controls.Add(this.submitComment_button);
            this.panel3.Location = new System.Drawing.Point(12, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 306);
            this.panel3.TabIndex = 20;
            // 
            // comment_text
            // 
            this.comment_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_text.Location = new System.Drawing.Point(13, 56);
            this.comment_text.Multiline = true;
            this.comment_text.Name = "comment_text";
            this.comment_text.ReadOnly = true;
            this.comment_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.comment_text.Size = new System.Drawing.Size(802, 186);
            this.comment_text.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Additional Comments:";
            // 
            // commentsubmit_text
            // 
            this.commentsubmit_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsubmit_text.Location = new System.Drawing.Point(13, 259);
            this.commentsubmit_text.Multiline = true;
            this.commentsubmit_text.Name = "commentsubmit_text";
            this.commentsubmit_text.Size = new System.Drawing.Size(755, 31);
            this.commentsubmit_text.TabIndex = 8;
            // 
            // submitComment_button
            // 
            this.submitComment_button.BackColor = System.Drawing.Color.White;
            this.submitComment_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitComment_button.BackgroundImage")));
            this.submitComment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitComment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitComment_button.Location = new System.Drawing.Point(774, 259);
            this.submitComment_button.Name = "submitComment_button";
            this.submitComment_button.Size = new System.Drawing.Size(41, 31);
            this.submitComment_button.TabIndex = 9;
            this.submitComment_button.UseVisualStyleBackColor = false;
            this.submitComment_button.Click += new System.EventHandler(this.submitComment_button_Click);
            // 
            // followup_panel
            // 
            this.followup_panel.AutoScroll = true;
            this.followup_panel.BackColor = System.Drawing.Color.Transparent;
            this.followup_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.followup_panel.Controls.Add(this.followsupItems_panel);
            this.followup_panel.Controls.Add(this.followup_label);
            this.followup_panel.Location = new System.Drawing.Point(495, 129);
            this.followup_panel.Name = "followup_panel";
            this.followup_panel.Size = new System.Drawing.Size(360, 254);
            this.followup_panel.TabIndex = 6;
            // 
            // followsupItems_panel
            // 
            this.followsupItems_panel.AutoScroll = true;
            this.followsupItems_panel.Location = new System.Drawing.Point(0, 52);
            this.followsupItems_panel.Name = "followsupItems_panel";
            this.followsupItems_panel.Size = new System.Drawing.Size(355, 200);
            this.followsupItems_panel.TabIndex = 2;
            // 
            // followup_label
            // 
            this.followup_label.AutoSize = true;
            this.followup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followup_label.Location = new System.Drawing.Point(12, 10);
            this.followup_label.Name = "followup_label";
            this.followup_label.Size = new System.Drawing.Size(137, 29);
            this.followup_label.TabIndex = 1;
            this.followup_label.Text = "Follow-Ups";
            // 
            // hide_success_label
            // 
            this.hide_success_label.Tick += new System.EventHandler(this.hide_success_label_Tick);
            // 
            // hide_error_label
            // 
            this.hide_error_label.Tick += new System.EventHandler(this.hide_error_label_Tick);
            // 
            // allReminders_panel
            // 
            this.allReminders_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allReminders_panel.Controls.Add(this.upcomingRem_labe);
            this.allReminders_panel.Controls.Add(this.reminders_panel);
            this.allReminders_panel.Controls.Add(this.addRrem_button);
            this.allReminders_panel.Controls.Add(this.setReminder_panel);
            this.allReminders_panel.Controls.Add(this.reminders_label);
            this.allReminders_panel.Location = new System.Drawing.Point(12, 993);
            this.allReminders_panel.Name = "allReminders_panel";
            this.allReminders_panel.Size = new System.Drawing.Size(843, 280);
            this.allReminders_panel.TabIndex = 21;
            // 
            // upcomingRem_labe
            // 
            this.upcomingRem_labe.AutoSize = true;
            this.upcomingRem_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingRem_labe.Location = new System.Drawing.Point(495, 13);
            this.upcomingRem_labe.Name = "upcomingRem_labe";
            this.upcomingRem_labe.Size = new System.Drawing.Size(141, 29);
            this.upcomingRem_labe.TabIndex = 25;
            this.upcomingRem_labe.Text = "Upcoming...";
            this.upcomingRem_labe.Visible = false;
            // 
            // reminders_panel
            // 
            this.reminders_panel.AutoScroll = true;
            this.reminders_panel.BackColor = System.Drawing.Color.White;
            this.reminders_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reminders_panel.Location = new System.Drawing.Point(483, 68);
            this.reminders_panel.Name = "reminders_panel";
            this.reminders_panel.Size = new System.Drawing.Size(345, 167);
            this.reminders_panel.TabIndex = 24;
            // 
            // addRrem_button
            // 
            this.addRrem_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRrem_button.BackgroundImage")));
            this.addRrem_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRrem_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRrem_button.FlatAppearance.BorderSize = 0;
            this.addRrem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRrem_button.Location = new System.Drawing.Point(149, 13);
            this.addRrem_button.Name = "addRrem_button";
            this.addRrem_button.Size = new System.Drawing.Size(29, 27);
            this.addRrem_button.TabIndex = 23;
            this.addRrem_button.UseVisualStyleBackColor = true;
            this.addRrem_button.Click += new System.EventHandler(this.addRrem_button_Click);
            // 
            // setReminder_panel
            // 
            this.setReminder_panel.Controls.Add(this.remMessage_text);
            this.setReminder_panel.Controls.Add(this.remMessage_label);
            this.setReminder_panel.Controls.Add(this.reminder_datetime);
            this.setReminder_panel.Controls.Add(this.reminderDate_label);
            this.setReminder_panel.Location = new System.Drawing.Point(17, 56);
            this.setReminder_panel.Name = "setReminder_panel";
            this.setReminder_panel.Size = new System.Drawing.Size(452, 196);
            this.setReminder_panel.TabIndex = 22;
            // 
            // remMessage_text
            // 
            this.remMessage_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remMessage_text.Location = new System.Drawing.Point(113, 58);
            this.remMessage_text.Multiline = true;
            this.remMessage_text.Name = "remMessage_text";
            this.remMessage_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.remMessage_text.Size = new System.Drawing.Size(329, 121);
            this.remMessage_text.TabIndex = 6;
            // 
            // remMessage_label
            // 
            this.remMessage_label.AutoSize = true;
            this.remMessage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remMessage_label.Location = new System.Drawing.Point(-5, 55);
            this.remMessage_label.Name = "remMessage_label";
            this.remMessage_label.Size = new System.Drawing.Size(99, 25);
            this.remMessage_label.TabIndex = 21;
            this.remMessage_label.Text = "Message:";
            // 
            // reminder_datetime
            // 
            this.reminder_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminder_datetime.Location = new System.Drawing.Point(113, 12);
            this.reminder_datetime.Name = "reminder_datetime";
            this.reminder_datetime.Size = new System.Drawing.Size(329, 30);
            this.reminder_datetime.TabIndex = 20;
            // 
            // reminderDate_label
            // 
            this.reminderDate_label.AutoSize = true;
            this.reminderDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderDate_label.Location = new System.Drawing.Point(-5, 17);
            this.reminderDate_label.Name = "reminderDate_label";
            this.reminderDate_label.Size = new System.Drawing.Size(59, 25);
            this.reminderDate_label.TabIndex = 4;
            this.reminderDate_label.Text = "Date:";
            // 
            // reminders_label
            // 
            this.reminders_label.AutoSize = true;
            this.reminders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminders_label.Location = new System.Drawing.Point(12, 11);
            this.reminders_label.Name = "reminders_label";
            this.reminders_label.Size = new System.Drawing.Size(131, 29);
            this.reminders_label.TabIndex = 4;
            this.reminders_label.Text = "Reminders";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 681);
            this.Controls.Add(this.allReminders_panel);
            this.Controls.Add(this.followup_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titlePanel);
            this.MaximumSize = new System.Drawing.Size(906, 1600);
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "EditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAppointment";
            this.Load += new System.EventHandler(this.EditAppointment_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.followup_panel.ResumeLayout(false);
            this.followup_panel.PerformLayout();
            this.allReminders_panel.ResumeLayout(false);
            this.allReminders_panel.PerformLayout();
            this.setReminder_panel.ResumeLayout(false);
            this.setReminder_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label statusShow_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label created_text;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tel2_text;
        private System.Windows.Forms.TextBox surname2_text;
        private System.Windows.Forms.TextBox name2_text;
        private System.Windows.Forms.TextBox id2_text;
        private System.Windows.Forms.CheckBox addPerson_check;
        private System.Windows.Forms.TextBox tel1_text;
        private System.Windows.Forms.TextBox surname1_text;
        private System.Windows.Forms.TextBox name1_text;
        private System.Windows.Forms.TextBox id1_text;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.Label personal_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_text;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label appInfo_label;
        private System.Windows.Forms.Label intermediary_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ComboBox types_combo;
        private System.Windows.Forms.TextBox intermediary_text;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel followup_panel;
        private System.Windows.Forms.Label followup_label;
        private System.Windows.Forms.Button followup_button;
        private System.Windows.Forms.LinkLabel parent_link;
        private System.Windows.Forms.Label parent_label;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel followsupItems_panel;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label saved_label;
        private System.Windows.Forms.Timer hide_success_label;
        private System.Windows.Forms.Label required_tel;
        private System.Windows.Forms.Label required_surname;
        private System.Windows.Forms.Label required_name;
        private System.Windows.Forms.Label required_id;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Timer hide_error_label;
        private System.Windows.Forms.TextBox comment_text;
        private System.Windows.Forms.TextBox commentsubmit_text;
        private System.Windows.Forms.Button submitComment_button;
        private System.Windows.Forms.Panel allReminders_panel;
        private System.Windows.Forms.Panel reminders_panel;
        private System.Windows.Forms.Button addRrem_button;
        private System.Windows.Forms.Panel setReminder_panel;
        private System.Windows.Forms.TextBox remMessage_text;
        private System.Windows.Forms.Label remMessage_label;
        private System.Windows.Forms.DateTimePicker reminder_datetime;
        private System.Windows.Forms.Label reminderDate_label;
        private System.Windows.Forms.Label reminders_label;
        private System.Windows.Forms.Label upcomingRem_labe;
        private System.Windows.Forms.Button print_button;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}