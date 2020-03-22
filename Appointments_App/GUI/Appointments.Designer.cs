using System.Windows.Forms;

namespace Appointments_App
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.todayAppointmentsTab = new System.Windows.Forms.TabPage();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.tools_panel = new System.Windows.Forms.Panel();
            this.rem_label = new System.Windows.Forms.Label();
            this.saveToCsv_button = new System.Windows.Forms.Button();
            this.refresh_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.importCSV_label = new System.Windows.Forms.Label();
            this.umportFromCsv_button = new System.Windows.Forms.Button();
            this.reminders_label = new System.Windows.Forms.Label();
            this.reminders_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settings_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filter_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.addAppointment_button = new System.Windows.Forms.Button();
            this.todayData = new System.Windows.Forms.DataGridView();
            this.title_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment_time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueType_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_label = new System.Windows.Forms.Label();
            this.scheduledAppointmentsTab = new System.Windows.Forms.TabPage();
            this.doneData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unscheduledAppointmentsTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.todayAppointmentsTab.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.tools_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayData)).BeginInit();
            this.scheduledAppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doneData)).BeginInit();
            this.unscheduledAppointmentsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.todayAppointmentsTab);
            this.tabControl1.Controls.Add(this.scheduledAppointmentsTab);
            this.tabControl1.Controls.Add(this.unscheduledAppointmentsTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1693, 855);
            this.tabControl1.TabIndex = 3;
            // 
            // todayAppointmentsTab
            // 
            this.todayAppointmentsTab.BackColor = System.Drawing.Color.White;
            this.todayAppointmentsTab.Controls.Add(this.dataPanel);
            this.todayAppointmentsTab.ForeColor = System.Drawing.Color.Black;
            this.todayAppointmentsTab.Location = new System.Drawing.Point(4, 38);
            this.todayAppointmentsTab.Name = "todayAppointmentsTab";
            this.todayAppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayAppointmentsTab.Size = new System.Drawing.Size(1685, 813);
            this.todayAppointmentsTab.TabIndex = 0;
            this.todayAppointmentsTab.Text = "Today\'s";
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.Transparent;
            this.dataPanel.Controls.Add(this.search_panel);
            this.dataPanel.Controls.Add(this.tools_panel);
            this.dataPanel.Controls.Add(this.todayData);
            this.dataPanel.Controls.Add(this.total_label);
            this.dataPanel.Location = new System.Drawing.Point(6, 6);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1673, 783);
            this.dataPanel.TabIndex = 4;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.linkLabel1);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.search_text);
            this.search_panel.Location = new System.Drawing.Point(361, 674);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(435, 89);
            this.search_panel.TabIndex = 24;
            this.search_panel.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(301, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 18);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear Search";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "search:";
            // 
            // search_text
            // 
            this.search_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(22, 36);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(373, 30);
            this.search_text.TabIndex = 0;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged);
            // 
            // tools_panel
            // 
            this.tools_panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tools_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tools_panel.Controls.Add(this.rem_label);
            this.tools_panel.Controls.Add(this.saveToCsv_button);
            this.tools_panel.Controls.Add(this.refresh_label);
            this.tools_panel.Controls.Add(this.refresh_button);
            this.tools_panel.Controls.Add(this.importCSV_label);
            this.tools_panel.Controls.Add(this.umportFromCsv_button);
            this.tools_panel.Controls.Add(this.reminders_label);
            this.tools_panel.Controls.Add(this.reminders_button);
            this.tools_panel.Controls.Add(this.label5);
            this.tools_panel.Controls.Add(this.label4);
            this.tools_panel.Controls.Add(this.settings_button);
            this.tools_panel.Controls.Add(this.label3);
            this.tools_panel.Controls.Add(this.label2);
            this.tools_panel.Controls.Add(this.filter_button);
            this.tools_panel.Controls.Add(this.search_label);
            this.tools_panel.Controls.Add(this.search_button);
            this.tools_panel.Controls.Add(this.addAppointment_button);
            this.tools_panel.Location = new System.Drawing.Point(6, 15);
            this.tools_panel.Name = "tools_panel";
            this.tools_panel.Size = new System.Drawing.Size(1664, 89);
            this.tools_panel.TabIndex = 13;
            // 
            // rem_label
            // 
            this.rem_label.AutoSize = true;
            this.rem_label.Location = new System.Drawing.Point(1037, 0);
            this.rem_label.Name = "rem_label";
            this.rem_label.Size = new System.Drawing.Size(95, 29);
            this.rem_label.TabIndex = 25;
            this.rem_label.Text = "label13";
            // 
            // saveToCsv_button
            // 
            this.saveToCsv_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveToCsv_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToCsv_button.BackgroundImage")));
            this.saveToCsv_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToCsv_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToCsv_button.FlatAppearance.BorderSize = 0;
            this.saveToCsv_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToCsv_button.Location = new System.Drawing.Point(443, 9);
            this.saveToCsv_button.Name = "saveToCsv_button";
            this.saveToCsv_button.Size = new System.Drawing.Size(64, 54);
            this.saveToCsv_button.TabIndex = 30;
            this.saveToCsv_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveToCsv_button.UseVisualStyleBackColor = false;
            this.saveToCsv_button.Click += new System.EventHandler(this.saveToCsv_button_Click);
            // 
            // refresh_label
            // 
            this.refresh_label.AutoSize = true;
            this.refresh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_label.Location = new System.Drawing.Point(276, 63);
            this.refresh_label.Name = "refresh_label";
            this.refresh_label.Size = new System.Drawing.Size(89, 20);
            this.refresh_label.TabIndex = 29;
            this.refresh_label.Text = "REFRESH";
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Location = new System.Drawing.Point(295, 6);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(55, 54);
            this.refresh_button.TabIndex = 28;
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // importCSV_label
            // 
            this.importCSV_label.AutoSize = true;
            this.importCSV_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCSV_label.Location = new System.Drawing.Point(580, 63);
            this.importCSV_label.Name = "importCSV_label";
            this.importCSV_label.Size = new System.Drawing.Size(123, 20);
            this.importCSV_label.TabIndex = 27;
            this.importCSV_label.Text = "IMPORT DATA";
            // 
            // umportFromCsv_button
            // 
            this.umportFromCsv_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.umportFromCsv_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("umportFromCsv_button.BackgroundImage")));
            this.umportFromCsv_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.umportFromCsv_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umportFromCsv_button.FlatAppearance.BorderSize = 0;
            this.umportFromCsv_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umportFromCsv_button.Location = new System.Drawing.Point(605, 6);
            this.umportFromCsv_button.Name = "umportFromCsv_button";
            this.umportFromCsv_button.Size = new System.Drawing.Size(64, 54);
            this.umportFromCsv_button.TabIndex = 26;
            this.umportFromCsv_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.umportFromCsv_button.UseVisualStyleBackColor = false;
            // 
            // reminders_label
            // 
            this.reminders_label.AutoSize = true;
            this.reminders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminders_label.Location = new System.Drawing.Point(958, 63);
            this.reminders_label.Name = "reminders_label";
            this.reminders_label.Size = new System.Drawing.Size(109, 20);
            this.reminders_label.TabIndex = 25;
            this.reminders_label.Text = "REMINDERS";
            // 
            // reminders_button
            // 
            this.reminders_button.BackColor = System.Drawing.Color.Transparent;
            this.reminders_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reminders_button.BackgroundImage")));
            this.reminders_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reminders_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reminders_button.FlatAppearance.BorderSize = 0;
            this.reminders_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminders_button.Location = new System.Drawing.Point(979, 6);
            this.reminders_button.Name = "reminders_button";
            this.reminders_button.Size = new System.Drawing.Size(59, 54);
            this.reminders_button.TabIndex = 24;
            this.reminders_button.UseVisualStyleBackColor = false;
            this.reminders_button.Click += new System.EventHandler(this.reminders_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "EXPORT DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(784, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "SETTINGS";
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings_button.BackgroundImage")));
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Location = new System.Drawing.Point(799, 6);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(59, 54);
            this.settings_button.TabIndex = 18;
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1123, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ADD APPOINTMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "FILTER";
            // 
            // filter_button
            // 
            this.filter_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.filter_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filter_button.BackgroundImage")));
            this.filter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_button.FlatAppearance.BorderSize = 0;
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Location = new System.Drawing.Point(153, 9);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(76, 49);
            this.filter_button.TabIndex = 15;
            this.filter_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filter_button.UseVisualStyleBackColor = false;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(32, 63);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(79, 20);
            this.search_label.TabIndex = 14;
            this.search_label.Text = "SEARCH";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(30, -1);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(81, 60);
            this.search_button.TabIndex = 13;
            this.search_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // addAppointment_button
            // 
            this.addAppointment_button.BackColor = System.Drawing.Color.Transparent;
            this.addAppointment_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAppointment_button.BackgroundImage")));
            this.addAppointment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAppointment_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointment_button.FlatAppearance.BorderSize = 0;
            this.addAppointment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointment_button.Location = new System.Drawing.Point(1168, 6);
            this.addAppointment_button.Name = "addAppointment_button";
            this.addAppointment_button.Size = new System.Drawing.Size(66, 59);
            this.addAppointment_button.TabIndex = 12;
            this.addAppointment_button.UseVisualStyleBackColor = false;
            this.addAppointment_button.Click += new System.EventHandler(this.addAppointment_button_Click);
            // 
            // todayData
            // 
            this.todayData.AllowUserToAddRows = false;
            this.todayData.AllowUserToDeleteRows = false;
            this.todayData.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.todayData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todayData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title_column,
            this.name_column,
            this.surname_column,
            this.appointment_time_column,
            this.issueType_column,
            this.comments_column});
            this.todayData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.todayData.Location = new System.Drawing.Point(6, 117);
            this.todayData.MultiSelect = false;
            this.todayData.Name = "todayData";
            this.todayData.ReadOnly = true;
            this.todayData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.todayData.RowTemplate.Height = 24;
            this.todayData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todayData.Size = new System.Drawing.Size(1664, 663);
            this.todayData.TabIndex = 3;
            this.todayData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todayData_CellContentClick);
            // 
            // title_column
            // 
            this.title_column.HeaderText = "Title";
            this.title_column.Name = "title_column";
            this.title_column.ReadOnly = true;
            this.title_column.Width = 400;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Width = 150;
            // 
            // surname_column
            // 
            this.surname_column.HeaderText = "Surname";
            this.surname_column.Name = "surname_column";
            this.surname_column.ReadOnly = true;
            this.surname_column.Width = 150;
            // 
            // appointment_time_column
            // 
            this.appointment_time_column.HeaderText = "Time";
            this.appointment_time_column.Name = "appointment_time_column";
            this.appointment_time_column.ReadOnly = true;
            // 
            // issueType_column
            // 
            this.issueType_column.HeaderText = "Appointment Type";
            this.issueType_column.Name = "issueType_column";
            this.issueType_column.ReadOnly = true;
            this.issueType_column.Width = 200;
            // 
            // comments_column
            // 
            this.comments_column.HeaderText = "Last Comment";
            this.comments_column.Name = "comments_column";
            this.comments_column.ReadOnly = true;
            this.comments_column.Width = 300;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(959, 296);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(81, 29);
            this.total_label.TabIndex = 23;
            this.total_label.Text = "label7";
            // 
            // scheduledAppointmentsTab
            // 
            this.scheduledAppointmentsTab.Controls.Add(this.doneData);
            this.scheduledAppointmentsTab.Location = new System.Drawing.Point(4, 38);
            this.scheduledAppointmentsTab.Name = "scheduledAppointmentsTab";
            this.scheduledAppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduledAppointmentsTab.Size = new System.Drawing.Size(1625, 813);
            this.scheduledAppointmentsTab.TabIndex = 1;
            this.scheduledAppointmentsTab.Text = "Scheduled";
            this.scheduledAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // doneData
            // 
            this.doneData.AllowUserToAddRows = false;
            this.doneData.AllowUserToDeleteRows = false;
            this.doneData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.doneData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doneData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.doneData.Location = new System.Drawing.Point(21, 39);
            this.doneData.Name = "doneData";
            this.doneData.ReadOnly = true;
            this.doneData.RowTemplate.Height = 24;
            this.doneData.Size = new System.Drawing.Size(1114, 630);
            this.doneData.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Date Created";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // unscheduledAppointmentsTab
            // 
            this.unscheduledAppointmentsTab.Controls.Add(this.panel2);
            this.unscheduledAppointmentsTab.Controls.Add(this.panel1);
            this.unscheduledAppointmentsTab.Location = new System.Drawing.Point(4, 38);
            this.unscheduledAppointmentsTab.Name = "unscheduledAppointmentsTab";
            this.unscheduledAppointmentsTab.Size = new System.Drawing.Size(1625, 813);
            this.unscheduledAppointmentsTab.TabIndex = 2;
            this.unscheduledAppointmentsTab.Text = "All";
            this.unscheduledAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Location = new System.Drawing.Point(13, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 89);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "IMPORT DATA";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(605, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 54);
            this.button8.TabIndex = 26;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(958, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "REMINDERS";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(979, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 54);
            this.button9.TabIndex = 24;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "EXPORT DATA";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(412, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 54);
            this.button10.TabIndex = 20;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(784, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "SETTINGS";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(799, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 54);
            this.button11.TabIndex = 18;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1123, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ADD APPOINTMENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "FILTER";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(196, 9);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 49);
            this.button12.TabIndex = 15;
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "SEARCH";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(30, -1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(81, 60);
            this.button13.TabIndex = 13;
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(1168, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(66, 59);
            this.button14.TabIndex = 12;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.allData);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1611, 794);
            this.panel1.TabIndex = 5;
            // 
            // allData
            // 
            this.allData.AllowUserToAddRows = false;
            this.allData.AllowUserToDeleteRows = false;
            this.allData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.allData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.created_column,
            this.dataGridViewTextBoxColumn10});
            this.allData.Location = new System.Drawing.Point(7, 132);
            this.allData.MultiSelect = false;
            this.allData.Name = "allData";
            this.allData.ReadOnly = true;
            this.allData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.allData.RowTemplate.Height = 24;
            this.allData.Size = new System.Drawing.Size(1326, 638);
            this.allData.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Appointment Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // created_column
            // 
            this.created_column.HeaderText = "Date Created";
            this.created_column.Name = "created_column";
            this.created_column.ReadOnly = true;
            this.created_column.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 300;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 868);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.todayAppointmentsTab.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.tools_panel.ResumeLayout(false);
            this.tools_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayData)).EndInit();
            this.scheduledAppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doneData)).EndInit();
            this.unscheduledAppointmentsTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage todayAppointmentsTab;
        private DataGridView todayData;
        private TabPage scheduledAppointmentsTab;
        private TabPage unscheduledAppointmentsTab;
        private DataGridView doneData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Panel dataPanel;
        private Panel panel1;
        private DataGridView allData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn created_column;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button addAppointment_button;
        private Panel tools_panel;
        private Label label3;
        private Label label2;
        private Button filter_button;
        private Label search_label;
        private Button search_button;
        private Label label4;
        private Button settings_button;
        private Label total_label;
        private Label label5;
        private Label importCSV_label;
        private Button umportFromCsv_button;
        private Label reminders_label;
        private Button reminders_button;
        private Panel panel2;
        private Label label1;
        private Button button8;
        private Label label6;
        private Button button9;
        private Label label7;
        private Button button10;
        private Label label8;
        private Button button11;
        private Label label9;
        private Label label10;
        private Button button12;
        private Label label11;
        private Button button13;
        private Button button14;
        private Label refresh_label;
        private Button refresh_button;
        private Button saveToCsv_button;
        private DataGridViewTextBoxColumn title_column;
        private DataGridViewTextBoxColumn name_column;
        private DataGridViewTextBoxColumn surname_column;
        private DataGridViewTextBoxColumn appointment_time_column;
        private DataGridViewTextBoxColumn issueType_column;
        private DataGridViewTextBoxColumn comments_column;
        private Panel search_panel;
        private Label label12;
        private TextBox search_text;
        private LinkLabel linkLabel1;
        public  Label rem_label;
    }
}

