namespace Appointments_App.GUI
{
    partial class AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.title_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intermediary_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.pageTitle_label = new System.Windows.Forms.Label();
            this.page_panel = new System.Windows.Forms.Panel();
            this.reminder_panel = new System.Windows.Forms.Panel();
            this.addReminder_check = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.remMessage_text = new System.Windows.Forms.TextBox();
            this.remMessage_label = new System.Windows.Forms.Label();
            this.reminder_datetime = new System.Windows.Forms.DateTimePicker();
            this.reminderDate_label = new System.Windows.Forms.Label();
            this.reminder_label = new System.Windows.Forms.Label();
            this.saved_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comment_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.types_combo = new System.Windows.Forms.ComboBox();
            this.intermediary_text = new System.Windows.Forms.TextBox();
            this.description_text = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.appInfo_label = new System.Windows.Forms.Label();
            this.hide_success_label = new System.Windows.Forms.Timer(this.components);
            this.hide_error_label = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.page_panel.SuspendLayout();
            this.reminder_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(71, 17);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(115, 25);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.intermediary_label);
            this.panel1.Controls.Add(this.type_label);
            this.panel1.Controls.Add(this.date_label);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Location = new System.Drawing.Point(31, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 161);
            this.panel1.TabIndex = 1;
            // 
            // intermediary_label
            // 
            this.intermediary_label.AutoSize = true;
            this.intermediary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediary_label.Location = new System.Drawing.Point(60, 122);
            this.intermediary_label.Name = "intermediary_label";
            this.intermediary_label.Size = new System.Drawing.Size(125, 25);
            this.intermediary_label.TabIndex = 3;
            this.intermediary_label.Text = "Intermediary:";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(8, 88);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(178, 25);
            this.type_label.TabIndex = 2;
            this.type_label.Text = "Appointment Type:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(12, 51);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(174, 25);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "Appointment Date:";
            // 
            // pageTitle_label
            // 
            this.pageTitle_label.AutoSize = true;
            this.pageTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle_label.Location = new System.Drawing.Point(26, 1);
            this.pageTitle_label.Name = "pageTitle_label";
            this.pageTitle_label.Size = new System.Drawing.Size(246, 36);
            this.pageTitle_label.TabIndex = 1;
            this.pageTitle_label.Text = "Add Appointment";
            // 
            // page_panel
            // 
            this.page_panel.BackColor = System.Drawing.Color.Transparent;
            this.page_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page_panel.Controls.Add(this.reminder_panel);
            this.page_panel.Controls.Add(this.saved_label);
            this.page_panel.Controls.Add(this.save_button);
            this.page_panel.Controls.Add(this.panel3);
            this.page_panel.Controls.Add(this.panel2);
            this.page_panel.Controls.Add(this.types_combo);
            this.page_panel.Controls.Add(this.intermediary_text);
            this.page_panel.Controls.Add(this.description_text);
            this.page_panel.Controls.Add(this.datePicker);
            this.page_panel.Controls.Add(this.panel1);
            this.page_panel.Controls.Add(this.panel4);
            this.page_panel.Location = new System.Drawing.Point(12, 20);
            this.page_panel.Name = "page_panel";
            this.page_panel.Size = new System.Drawing.Size(856, 987);
            this.page_panel.TabIndex = 2;
            // 
            // reminder_panel
            // 
            this.reminder_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reminder_panel.Controls.Add(this.addReminder_check);
            this.reminder_panel.Controls.Add(this.panel6);
            this.reminder_panel.Controls.Add(this.reminder_label);
            this.reminder_panel.Location = new System.Drawing.Point(19, 780);
            this.reminder_panel.MaximumSize = new System.Drawing.Size(811, 200);
            this.reminder_panel.Name = "reminder_panel";
            this.reminder_panel.Size = new System.Drawing.Size(811, 45);
            this.reminder_panel.TabIndex = 18;
            // 
            // addReminder_check
            // 
            this.addReminder_check.AutoSize = true;
            this.addReminder_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReminder_check.Location = new System.Drawing.Point(214, 16);
            this.addReminder_check.Name = "addReminder_check";
            this.addReminder_check.Size = new System.Drawing.Size(18, 17);
            this.addReminder_check.TabIndex = 22;
            this.addReminder_check.UseVisualStyleBackColor = true;
            this.addReminder_check.CheckedChanged += new System.EventHandler(this.addReminder_check_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.remMessage_text);
            this.panel6.Controls.Add(this.remMessage_label);
            this.panel6.Controls.Add(this.reminder_datetime);
            this.panel6.Controls.Add(this.reminderDate_label);
            this.panel6.Location = new System.Drawing.Point(17, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(789, 120);
            this.panel6.TabIndex = 21;
            // 
            // remMessage_text
            // 
            this.remMessage_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remMessage_text.Location = new System.Drawing.Point(113, 58);
            this.remMessage_text.Multiline = true;
            this.remMessage_text.Name = "remMessage_text";
            this.remMessage_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.remMessage_text.Size = new System.Drawing.Size(662, 56);
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
            this.reminder_datetime.Size = new System.Drawing.Size(270, 30);
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
            // reminder_label
            // 
            this.reminder_label.AutoSize = true;
            this.reminder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminder_label.Location = new System.Drawing.Point(12, 7);
            this.reminder_label.Name = "reminder_label";
            this.reminder_label.Size = new System.Drawing.Size(168, 29);
            this.reminder_label.TabIndex = 4;
            this.reminder_label.Text = "Add Reminder";
            // 
            // saved_label
            // 
            this.saved_label.AutoSize = true;
            this.saved_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.saved_label.Location = new System.Drawing.Point(775, 85);
            this.saved_label.Name = "saved_label";
            this.saved_label.Size = new System.Drawing.Size(60, 18);
            this.saved_label.TabIndex = 19;
            this.saved_label.Text = "SAVED!";
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.Location = new System.Drawing.Point(781, 26);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(51, 54);
            this.save_button.TabIndex = 3;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comment_text);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(19, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 208);
            this.panel3.TabIndex = 17;
            // 
            // comment_text
            // 
            this.comment_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_text.Location = new System.Drawing.Point(13, 56);
            this.comment_text.Multiline = true;
            this.comment_text.Name = "comment_text";
            this.comment_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.comment_text.Size = new System.Drawing.Size(779, 129);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel2.Location = new System.Drawing.Point(19, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 262);
            this.panel2.TabIndex = 4;
            // 
            // tel2_text
            // 
            this.tel2_text.Enabled = false;
            this.tel2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel2_text.Location = new System.Drawing.Point(482, 163);
            this.tel2_text.Name = "tel2_text";
            this.tel2_text.Size = new System.Drawing.Size(294, 30);
            this.tel2_text.TabIndex = 16;
            // 
            // surname2_text
            // 
            this.surname2_text.Enabled = false;
            this.surname2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname2_text.Location = new System.Drawing.Point(482, 125);
            this.surname2_text.Name = "surname2_text";
            this.surname2_text.Size = new System.Drawing.Size(294, 30);
            this.surname2_text.TabIndex = 15;
            // 
            // name2_text
            // 
            this.name2_text.Enabled = false;
            this.name2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2_text.Location = new System.Drawing.Point(482, 89);
            this.name2_text.Name = "name2_text";
            this.name2_text.Size = new System.Drawing.Size(294, 30);
            this.name2_text.TabIndex = 14;
            // 
            // id2_text
            // 
            this.id2_text.Enabled = false;
            this.id2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id2_text.Location = new System.Drawing.Point(482, 52);
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
            this.addPerson_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // types_combo
            // 
            this.types_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types_combo.FormattingEnabled = true;
            this.types_combo.Location = new System.Drawing.Point(224, 162);
            this.types_combo.Name = "types_combo";
            this.types_combo.Size = new System.Drawing.Size(481, 33);
            this.types_combo.TabIndex = 6;
            // 
            // intermediary_text
            // 
            this.intermediary_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediary_text.Location = new System.Drawing.Point(224, 201);
            this.intermediary_text.Name = "intermediary_text";
            this.intermediary_text.Size = new System.Drawing.Size(481, 30);
            this.intermediary_text.TabIndex = 4;
            // 
            // description_text
            // 
            this.description_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_text.Location = new System.Drawing.Point(224, 90);
            this.description_text.Name = "description_text";
            this.description_text.Size = new System.Drawing.Size(481, 30);
            this.description_text.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(224, 128);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(270, 30);
            this.datePicker.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.error_label);
            this.panel4.Controls.Add(this.TimePicker);
            this.panel4.Controls.Add(this.appInfo_label);
            this.panel4.Location = new System.Drawing.Point(19, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 229);
            this.panel4.TabIndex = 18;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.LightCoral;
            this.error_label.Location = new System.Drawing.Point(501, 26);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(184, 18);
            this.error_label.TabIndex = 20;
            this.error_label.Text = "PLEASE FILL ALL FIELDS!";
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(482, 100);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(203, 30);
            this.TimePicker.TabIndex = 18;
            // 
            // appInfo_label
            // 
            this.appInfo_label.AutoSize = true;
            this.appInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appInfo_label.Location = new System.Drawing.Point(11, 15);
            this.appInfo_label.Name = "appInfo_label";
            this.appInfo_label.Size = new System.Drawing.Size(273, 29);
            this.appInfo_label.TabIndex = 17;
            this.appInfo_label.Text = "Appointment Information";
            // 
            // hide_success_label
            // 
            this.hide_success_label.Tick += new System.EventHandler(this.hide_success_label_Tick);
            // 
            // hide_error_label
            // 
            this.hide_error_label.Tick += new System.EventHandler(this.hide_error_label_Tick);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(917, 739);
            this.Controls.Add(this.pageTitle_label);
            this.Controls.Add(this.page_panel);
            this.MaximumSize = new System.Drawing.Size(939, 790);
            this.MinimumSize = new System.Drawing.Size(939, 790);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.page_panel.ResumeLayout(false);
            this.page_panel.PerformLayout();
            this.reminder_panel.ResumeLayout(false);
            this.reminder_panel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pageTitle_label;
        private System.Windows.Forms.Panel page_panel;
        private System.Windows.Forms.Label intermediary_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox intermediary_text;
        private System.Windows.Forms.TextBox description_text;
        private System.Windows.Forms.DateTimePicker datePicker;
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
        private System.Windows.Forms.ComboBox types_combo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label appInfo_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label saved_label;
        private System.Windows.Forms.Timer hide_success_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox comment_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Timer hide_error_label;
        private System.Windows.Forms.Panel reminder_panel;
        private System.Windows.Forms.CheckBox addReminder_check;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker reminder_datetime;
        private System.Windows.Forms.Label reminderDate_label;
        private System.Windows.Forms.Label reminder_label;
        private System.Windows.Forms.TextBox remMessage_text;
        private System.Windows.Forms.Label remMessage_label;
    }
}