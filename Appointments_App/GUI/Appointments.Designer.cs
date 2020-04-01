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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.todayAppointmentsTab = new System.Windows.Forms.TabPage();
            this.totalApp_label = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.noAppointments_labe = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.counterToday_label = new System.Windows.Forms.Label();
            this.tools_panel = new System.Windows.Forms.Panel();
            this.rem_label = new System.Windows.Forms.Label();
            this.saveToCsv_button = new System.Windows.Forms.Button();
            this.refresh_label = new System.Windows.Forms.Label();
            this.search_panel = new System.Windows.Forms.Panel();
            this.clearSerach = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
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
            this.total_label = new System.Windows.Forms.Label();
            this.scheduledAppointmentsTab = new System.Windows.Forms.TabPage();
            this.doneData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unscheduledAppointmentsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allDate_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allRemindersCount_label = new System.Windows.Forms.Label();
            this.allExport_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.allSearch_panel = new System.Windows.Forms.Panel();
            this.allSearchClear_label = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.allSearch_text = new System.Windows.Forms.TextBox();
            this.allRefresh_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.allImport_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.allReminders_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.allSettings_button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.allFilter_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.allSearch_button = new System.Windows.Forms.Button();
            this.allAddApp_button = new System.Windows.Forms.Button();
            this.counterAll_label = new System.Windows.Forms.Label();
            this.allAppoitnmentsData = new System.Windows.Forms.DataGridView();
            this.pbImportHider = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.todayAppointmentsTab.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.tools_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayData)).BeginInit();
            this.scheduledAppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doneData)).BeginInit();
            this.unscheduledAppointmentsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.allSearch_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allAppoitnmentsData)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1693, 857);
            this.tabControl1.TabIndex = 3;
            // 
            // todayAppointmentsTab
            // 
            this.todayAppointmentsTab.BackColor = System.Drawing.Color.White;
            this.todayAppointmentsTab.Controls.Add(this.totalApp_label);
            this.todayAppointmentsTab.Controls.Add(this.dataPanel);
            this.todayAppointmentsTab.ForeColor = System.Drawing.Color.Black;
            this.todayAppointmentsTab.Location = new System.Drawing.Point(4, 38);
            this.todayAppointmentsTab.Name = "todayAppointmentsTab";
            this.todayAppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayAppointmentsTab.Size = new System.Drawing.Size(1685, 815);
            this.todayAppointmentsTab.TabIndex = 0;
            this.todayAppointmentsTab.Text = "Today\'s";
            // 
            // totalApp_label
            // 
            this.totalApp_label.AutoSize = true;
            this.totalApp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalApp_label.ForeColor = System.Drawing.Color.DimGray;
            this.totalApp_label.Location = new System.Drawing.Point(7, 803);
            this.totalApp_label.Name = "totalApp_label";
            this.totalApp_label.Size = new System.Drawing.Size(0, 18);
            this.totalApp_label.TabIndex = 5;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.Transparent;
            this.dataPanel.Controls.Add(this.pb);
            this.dataPanel.Controls.Add(this.noAppointments_labe);
            this.dataPanel.Controls.Add(this.date_label);
            this.dataPanel.Controls.Add(this.counterToday_label);
            this.dataPanel.Controls.Add(this.tools_panel);
            this.dataPanel.Controls.Add(this.todayData);
            this.dataPanel.Controls.Add(this.total_label);
            this.dataPanel.Location = new System.Drawing.Point(6, 6);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1673, 794);
            this.dataPanel.TabIndex = 4;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(6, 105);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1665, 11);
            this.pb.TabIndex = 32;
            this.pb.Visible = false;
            // 
            // noAppointments_labe
            // 
            this.noAppointments_labe.AutoSize = true;
            this.noAppointments_labe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.noAppointments_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAppointments_labe.Location = new System.Drawing.Point(650, 433);
            this.noAppointments_labe.Name = "noAppointments_labe";
            this.noAppointments_labe.Size = new System.Drawing.Size(343, 29);
            this.noAppointments_labe.TabIndex = 31;
            this.noAppointments_labe.Text = "NO APPOINTMENTS TODAY!";
            this.noAppointments_labe.Visible = false;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.DimGray;
            this.date_label.Location = new System.Drawing.Point(1434, 773);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 18);
            this.date_label.TabIndex = 26;
            this.date_label.Text = "date";
            // 
            // counterToday_label
            // 
            this.counterToday_label.AutoSize = true;
            this.counterToday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterToday_label.ForeColor = System.Drawing.Color.DimGray;
            this.counterToday_label.Location = new System.Drawing.Point(9, 773);
            this.counterToday_label.Name = "counterToday_label";
            this.counterToday_label.Size = new System.Drawing.Size(45, 18);
            this.counterToday_label.TabIndex = 25;
            this.counterToday_label.Text = "count";
            // 
            // tools_panel
            // 
            this.tools_panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tools_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tools_panel.Controls.Add(this.rem_label);
            this.tools_panel.Controls.Add(this.saveToCsv_button);
            this.tools_panel.Controls.Add(this.refresh_label);
            this.tools_panel.Controls.Add(this.search_panel);
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
            this.rem_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem_label.ForeColor = System.Drawing.Color.Maroon;
            this.rem_label.Location = new System.Drawing.Point(1049, 0);
            this.rem_label.Name = "rem_label";
            this.rem_label.Size = new System.Drawing.Size(27, 29);
            this.rem_label.TabIndex = 25;
            this.rem_label.Text = "0";
            // 
            // saveToCsv_button
            // 
            this.saveToCsv_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveToCsv_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToCsv_button.BackgroundImage")));
            this.saveToCsv_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToCsv_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToCsv_button.FlatAppearance.BorderSize = 0;
            this.saveToCsv_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToCsv_button.Location = new System.Drawing.Point(502, 9);
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
            this.refresh_label.Location = new System.Drawing.Point(335, 63);
            this.refresh_label.Name = "refresh_label";
            this.refresh_label.Size = new System.Drawing.Size(89, 20);
            this.refresh_label.TabIndex = 29;
            this.refresh_label.Text = "REFRESH";
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.clearSerach);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.search_text);
            this.search_panel.Location = new System.Drawing.Point(1227, 1);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(435, 89);
            this.search_panel.TabIndex = 24;
            this.search_panel.Visible = false;
            // 
            // clearSerach
            // 
            this.clearSerach.AutoSize = true;
            this.clearSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSerach.Location = new System.Drawing.Point(301, 14);
            this.clearSerach.Name = "clearSerach";
            this.clearSerach.Size = new System.Drawing.Size(94, 18);
            this.clearSerach.TabIndex = 32;
            this.clearSerach.TabStop = true;
            this.clearSerach.Text = "Clear Search";
            this.clearSerach.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearSerach_LinkClicked_1);
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
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Location = new System.Drawing.Point(354, 6);
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
            this.importCSV_label.Location = new System.Drawing.Point(643, 63);
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
            this.umportFromCsv_button.Location = new System.Drawing.Point(668, 6);
            this.umportFromCsv_button.Name = "umportFromCsv_button";
            this.umportFromCsv_button.Size = new System.Drawing.Size(64, 54);
            this.umportFromCsv_button.TabIndex = 26;
            this.umportFromCsv_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.umportFromCsv_button.UseVisualStyleBackColor = false;
            this.umportFromCsv_button.Click += new System.EventHandler(this.umportFromCsv_button_Click);
            // 
            // reminders_label
            // 
            this.reminders_label.AutoSize = true;
            this.reminders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminders_label.Location = new System.Drawing.Point(970, 63);
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
            this.reminders_button.Location = new System.Drawing.Point(991, 6);
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
            this.label5.Location = new System.Drawing.Point(467, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "EXPORT DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(826, 63);
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
            this.settings_button.Location = new System.Drawing.Point(841, 6);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(59, 54);
            this.settings_button.TabIndex = 18;
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ADD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 63);
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
            this.filter_button.Enabled = false;
            this.filter_button.FlatAppearance.BorderSize = 0;
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Location = new System.Drawing.Point(191, 8);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(76, 49);
            this.filter_button.TabIndex = 15;
            this.filter_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.filter_button.UseVisualStyleBackColor = false;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(1124, 67);
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
            this.search_button.Location = new System.Drawing.Point(1122, 3);
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
            this.addAppointment_button.Location = new System.Drawing.Point(51, 4);
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
            this.todayData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.todayData.Location = new System.Drawing.Point(6, 117);
            this.todayData.MultiSelect = false;
            this.todayData.Name = "todayData";
            this.todayData.ReadOnly = true;
            this.todayData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.todayData.RowTemplate.Height = 24;
            this.todayData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todayData.Size = new System.Drawing.Size(1663, 653);
            this.todayData.TabIndex = 3;
            this.todayData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todayData_CellContentClick);
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
            this.scheduledAppointmentsTab.Size = new System.Drawing.Size(1685, 815);
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
            this.unscheduledAppointmentsTab.Controls.Add(this.panel1);
            this.unscheduledAppointmentsTab.Location = new System.Drawing.Point(4, 38);
            this.unscheduledAppointmentsTab.Name = "unscheduledAppointmentsTab";
            this.unscheduledAppointmentsTab.Size = new System.Drawing.Size(1685, 815);
            this.unscheduledAppointmentsTab.TabIndex = 2;
            this.unscheduledAppointmentsTab.Text = "All";
            this.unscheduledAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.allDate_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.counterAll_label);
            this.panel1.Controls.Add(this.allAppoitnmentsData);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1676, 794);
            this.panel1.TabIndex = 5;
            // 
            // allDate_label
            // 
            this.allDate_label.AutoSize = true;
            this.allDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDate_label.ForeColor = System.Drawing.Color.DimGray;
            this.allDate_label.Location = new System.Drawing.Point(1432, 771);
            this.allDate_label.Name = "allDate_label";
            this.allDate_label.Size = new System.Drawing.Size(36, 18);
            this.allDate_label.TabIndex = 28;
            this.allDate_label.Text = "date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.allRemindersCount_label);
            this.panel2.Controls.Add(this.allExport_button);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.allSearch_panel);
            this.panel2.Controls.Add(this.allRefresh_button);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.allImport_button);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.allReminders_button);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.allSettings_button);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.allFilter_button);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.allSearch_button);
            this.panel2.Controls.Add(this.allAddApp_button);
            this.panel2.Location = new System.Drawing.Point(7, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1664, 89);
            this.panel2.TabIndex = 27;
            // 
            // allRemindersCount_label
            // 
            this.allRemindersCount_label.AutoSize = true;
            this.allRemindersCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRemindersCount_label.ForeColor = System.Drawing.Color.Maroon;
            this.allRemindersCount_label.Location = new System.Drawing.Point(1049, 0);
            this.allRemindersCount_label.Name = "allRemindersCount_label";
            this.allRemindersCount_label.Size = new System.Drawing.Size(27, 29);
            this.allRemindersCount_label.TabIndex = 25;
            this.allRemindersCount_label.Text = "0";
            // 
            // allExport_button
            // 
            this.allExport_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.allExport_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allExport_button.BackgroundImage")));
            this.allExport_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allExport_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allExport_button.FlatAppearance.BorderSize = 0;
            this.allExport_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allExport_button.Location = new System.Drawing.Point(502, 9);
            this.allExport_button.Name = "allExport_button";
            this.allExport_button.Size = new System.Drawing.Size(64, 54);
            this.allExport_button.TabIndex = 30;
            this.allExport_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allExport_button.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "REFRESH";
            // 
            // allSearch_panel
            // 
            this.allSearch_panel.Controls.Add(this.allSearchClear_label);
            this.allSearch_panel.Controls.Add(this.label7);
            this.allSearch_panel.Controls.Add(this.allSearch_text);
            this.allSearch_panel.Location = new System.Drawing.Point(1227, 1);
            this.allSearch_panel.Name = "allSearch_panel";
            this.allSearch_panel.Size = new System.Drawing.Size(435, 89);
            this.allSearch_panel.TabIndex = 24;
            this.allSearch_panel.Visible = false;
            // 
            // allSearchClear_label
            // 
            this.allSearchClear_label.AutoSize = true;
            this.allSearchClear_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSearchClear_label.Location = new System.Drawing.Point(301, 14);
            this.allSearchClear_label.Name = "allSearchClear_label";
            this.allSearchClear_label.Size = new System.Drawing.Size(94, 18);
            this.allSearchClear_label.TabIndex = 32;
            this.allSearchClear_label.TabStop = true;
            this.allSearchClear_label.Text = "Clear Search";
            this.allSearchClear_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allSearchClear_label_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "search:";
            // 
            // allSearch_text
            // 
            this.allSearch_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSearch_text.Location = new System.Drawing.Point(22, 36);
            this.allSearch_text.Name = "allSearch_text";
            this.allSearch_text.Size = new System.Drawing.Size(373, 30);
            this.allSearch_text.TabIndex = 0;
            this.allSearch_text.TextChanged += new System.EventHandler(this.allSearch_text_TextChanged);
            // 
            // allRefresh_button
            // 
            this.allRefresh_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.allRefresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allRefresh_button.BackgroundImage")));
            this.allRefresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allRefresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allRefresh_button.FlatAppearance.BorderSize = 0;
            this.allRefresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allRefresh_button.Location = new System.Drawing.Point(354, 6);
            this.allRefresh_button.Name = "allRefresh_button";
            this.allRefresh_button.Size = new System.Drawing.Size(55, 54);
            this.allRefresh_button.TabIndex = 28;
            this.allRefresh_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allRefresh_button.UseVisualStyleBackColor = false;
            this.allRefresh_button.Click += new System.EventHandler(this.allRefresh_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(643, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "IMPORT DATA";
            // 
            // allImport_button
            // 
            this.allImport_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.allImport_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allImport_button.BackgroundImage")));
            this.allImport_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allImport_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allImport_button.FlatAppearance.BorderSize = 0;
            this.allImport_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allImport_button.Location = new System.Drawing.Point(668, 6);
            this.allImport_button.Name = "allImport_button";
            this.allImport_button.Size = new System.Drawing.Size(64, 54);
            this.allImport_button.TabIndex = 26;
            this.allImport_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allImport_button.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(970, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "REMINDERS";
            // 
            // allReminders_button
            // 
            this.allReminders_button.BackColor = System.Drawing.Color.Transparent;
            this.allReminders_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allReminders_button.BackgroundImage")));
            this.allReminders_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allReminders_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allReminders_button.FlatAppearance.BorderSize = 0;
            this.allReminders_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allReminders_button.Location = new System.Drawing.Point(991, 6);
            this.allReminders_button.Name = "allReminders_button";
            this.allReminders_button.Size = new System.Drawing.Size(59, 54);
            this.allReminders_button.TabIndex = 24;
            this.allReminders_button.UseVisualStyleBackColor = false;
            this.allReminders_button.Click += new System.EventHandler(this.allReminders_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "EXPORT DATA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(826, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "SETTINGS";
            // 
            // allSettings_button
            // 
            this.allSettings_button.BackColor = System.Drawing.Color.Transparent;
            this.allSettings_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allSettings_button.BackgroundImage")));
            this.allSettings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allSettings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allSettings_button.FlatAppearance.BorderSize = 0;
            this.allSettings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allSettings_button.Location = new System.Drawing.Point(841, 6);
            this.allSettings_button.Name = "allSettings_button";
            this.allSettings_button.Size = new System.Drawing.Size(59, 54);
            this.allSettings_button.TabIndex = 18;
            this.allSettings_button.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "ADD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "FILTER";
            // 
            // allFilter_button
            // 
            this.allFilter_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.allFilter_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allFilter_button.BackgroundImage")));
            this.allFilter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allFilter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allFilter_button.FlatAppearance.BorderSize = 0;
            this.allFilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allFilter_button.Location = new System.Drawing.Point(191, 8);
            this.allFilter_button.Name = "allFilter_button";
            this.allFilter_button.Size = new System.Drawing.Size(76, 49);
            this.allFilter_button.TabIndex = 15;
            this.allFilter_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allFilter_button.UseVisualStyleBackColor = false;
            this.allFilter_button.Click += new System.EventHandler(this.allFilter_button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1124, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "SEARCH";
            // 
            // allSearch_button
            // 
            this.allSearch_button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.allSearch_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allSearch_button.BackgroundImage")));
            this.allSearch_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allSearch_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allSearch_button.FlatAppearance.BorderSize = 0;
            this.allSearch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allSearch_button.Location = new System.Drawing.Point(1122, 3);
            this.allSearch_button.Name = "allSearch_button";
            this.allSearch_button.Size = new System.Drawing.Size(81, 60);
            this.allSearch_button.TabIndex = 13;
            this.allSearch_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allSearch_button.UseVisualStyleBackColor = false;
            this.allSearch_button.Click += new System.EventHandler(this.allSearch_button_Click);
            // 
            // allAddApp_button
            // 
            this.allAddApp_button.BackColor = System.Drawing.Color.Transparent;
            this.allAddApp_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allAddApp_button.BackgroundImage")));
            this.allAddApp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allAddApp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allAddApp_button.FlatAppearance.BorderSize = 0;
            this.allAddApp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allAddApp_button.Location = new System.Drawing.Point(51, 4);
            this.allAddApp_button.Name = "allAddApp_button";
            this.allAddApp_button.Size = new System.Drawing.Size(66, 59);
            this.allAddApp_button.TabIndex = 12;
            this.allAddApp_button.UseVisualStyleBackColor = false;
            this.allAddApp_button.Click += new System.EventHandler(this.allAddApp_button_Click);
            // 
            // counterAll_label
            // 
            this.counterAll_label.AutoSize = true;
            this.counterAll_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterAll_label.ForeColor = System.Drawing.Color.DimGray;
            this.counterAll_label.Location = new System.Drawing.Point(13, 771);
            this.counterAll_label.Name = "counterAll_label";
            this.counterAll_label.Size = new System.Drawing.Size(45, 18);
            this.counterAll_label.TabIndex = 26;
            this.counterAll_label.Text = "count";
            // 
            // allAppoitnmentsData
            // 
            this.allAppoitnmentsData.AllowUserToAddRows = false;
            this.allAppoitnmentsData.AllowUserToDeleteRows = false;
            this.allAppoitnmentsData.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.allAppoitnmentsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allAppoitnmentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAppoitnmentsData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.allAppoitnmentsData.Location = new System.Drawing.Point(7, 113);
            this.allAppoitnmentsData.MultiSelect = false;
            this.allAppoitnmentsData.Name = "allAppoitnmentsData";
            this.allAppoitnmentsData.ReadOnly = true;
            this.allAppoitnmentsData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.allAppoitnmentsData.RowTemplate.Height = 24;
            this.allAppoitnmentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allAppoitnmentsData.Size = new System.Drawing.Size(1663, 653);
            this.allAppoitnmentsData.TabIndex = 4;
            this.allAppoitnmentsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allAppoitnmentsData_CellContentClick);
            // 
            // pbImportHider
            // 
            this.pbImportHider.Tick += new System.EventHandler(this.pbImportHider_Tick);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 862);
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
            this.todayAppointmentsTab.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.tools_panel.ResumeLayout(false);
            this.tools_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayData)).EndInit();
            this.scheduledAppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doneData)).EndInit();
            this.unscheduledAppointmentsTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.allSearch_panel.ResumeLayout(false);
            this.allSearch_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allAppoitnmentsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage todayAppointmentsTab;
        public DataGridView todayData;
        private TabPage scheduledAppointmentsTab;
        private TabPage unscheduledAppointmentsTab;
        private DataGridView doneData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Panel dataPanel;
        private Panel panel1;
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
        private Label refresh_label;
        private Button refresh_button;
        private Button saveToCsv_button;
        private Panel search_panel;
        private Label label12;
        private TextBox search_text;
        private LinkLabel clearSerach;
        public  Label rem_label;
        private Label totalApp_label;
        private Label counterToday_label;
        private Label date_label;
        private Label noAppointments_labe;
        private ProgressBar pb;
        private Timer pbImportHider;
        public DataGridView allAppoitnmentsData;
        public Label counterAll_label;
        private Panel panel2;
        public Label allRemindersCount_label;
        private Button allExport_button;
        private Label label6;
        private Panel allSearch_panel;
        private LinkLabel allSearchClear_label;
        private Label label7;
        private TextBox allSearch_text;
        private Button allRefresh_button;
        private Label label8;
        private Button allImport_button;
        private Label label9;
        private Button allReminders_button;
        private Label label10;
        private Label label11;
        private Button allSettings_button;
        private Label label13;
        private Label label14;
        private Button allFilter_button;
        private Label label15;
        private Button allSearch_button;
        private Button allAddApp_button;
        private Label allDate_label;
    }
}

