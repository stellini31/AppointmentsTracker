using Appointments_App.Classes;
using Appointments_App.Database;
using Appointments_App.GUI;
using Appointments_App.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments_App
{
    public partial class Appointments : Form
    {
        database dbConn;
        List<appointment> todayAppointments;
        DataTable dtTodayAppoitnemts;
        List<appointment> searchedTodayAppointments = new List<appointment>();
        string todayRemindersCount;
        public int TodayAppointmentsAll;
        int progressVisibleTime = 1500; //ms

        public Appointments()
        {
            InitializeComponent();
            dbConn = new database();
            this.todayAppointments = dbConn.getTodayAppointments();
            this.dtTodayAppoitnemts = dbConn.getTodayAppointmentsDataTable();
            TodayAppointmentsAll = todayAppointments.Count();
            date_label.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if(TodayAppointmentsAll == 0)
            {
                noAppointments_labe.Visible = true;
            }

            this.label13.Text = "Showing " + TodayAppointmentsAll.ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////////////TODAY APPOINTMENTS////////////////////
            this.populateTodayAppointments(this.todayAppointments);
            ////////////////////END TODAY APPOINTMENTS////////////////////

            this.updateRemindersCount();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointment ad = new AddAppointment();
            ad.Show();
        }

        private void todayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            appointment app;
            if(index > -1)
            {
                if(this.searchedTodayAppointments.Count != 0)
                {
                    app = searchedTodayAppointments[index];
                }
                else
                {
                    app = todayAppointments[index];
                }
                EditAppointment ea = new EditAppointment(app);
                ea.ShowDialog();
            }
        }

        private void saveToCsv_button_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> appTypes = dbConn.getAllAppointmentTypesDict();
            Export.exportAppointments(this.todayAppointments, appTypes, "Today Appointments", pb);

            pbImportHider.Interval = progressVisibleTime;
            pbImportHider.Tick += pbImportHider_Tick;
            pbImportHider.Start();
        }

        

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.todayAppointments = dbConn.getTodayAppointments();
            TodayAppointmentsAll = todayAppointments.Count();

            pb.Visible = true;
            pb.Minimum = 1;
            pb.Maximum = TodayAppointmentsAll;

            this.label13.Text = "Showing " + TodayAppointmentsAll.ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments";
            this.populateTodayAppointments(this.todayAppointments);
            this.updateRemindersCount();

            if(todayAppointments.Count() > 0)
            {
                noAppointments_labe.Hide();
            }

            pbImportHider.Interval = progressVisibleTime;
            pbImportHider.Tick += pbImportHider_Tick;
            pbImportHider.Start();
        }

        private void addAppointment_button_Click(object sender, EventArgs e)
        {
            AddAppointment aa = new AddAppointment();
            aa.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_text.Text = "";
            this.populateTodayAppointments(this.todayAppointments);
            label13.Text = "Showing " + TodayAppointmentsAll.ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments";
            this.searchedTodayAppointments = new List<appointment>();
        }

        private void reminders_button_Click(object sender, EventArgs e)
        {
            Reminders rem = new Reminders(this);
            rem.ShowDialog();
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            Filter fil = new Filter();
            fil.ShowDialog();
        }

        private void populateTodayAppointments(List<appointment> appointments)
        {
            if (this.todayData.InvokeRequired)
                todayData.Invoke((MethodInvoker)delegate ()
                {
                    populateTodayAppointments(appointments);
                });
            else
            {
                //todayData.DataSource = null;
                //todayData.Rows.Clear();

                DataTable table = this.ConvertToDataTable(appointments);
                
                /*foreach (appointment a in appointments)
                {
                    string appointmentType = dbConn.getAppointmentTypeDesc(a.AppointmentTypeId);
                    string lastComment = String.Empty;
                    if (a.Comments.Count != 0)
                    {
                        lastComment = a.Comments[a.Comments.Count() - 1].CommentText;
                    }
                    this.todayData.Rows.Add(a.AppointmentDesc, a.PersonName, a.PersonSurname, a.AppointmentDate.ToString("HH:mm"), appointmentType, lastComment);
                    pb.PerformStep();
                }*/

                this.todayData.DataSource = table;
                this.todayData.Columns[0].Width = 300;
                this.todayData.Columns[1].Width = 150;
                this.todayData.Columns[2].Width = 150;
                this.todayData.Columns[3].Width = 150;
                this.todayData.Columns[4].Width = 150;
                this.todayData.Columns[5].Width = 350;
            }
        }

        public DataTable ConvertToDataTable(List<appointment> appointments)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Surname", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Appointment Type", typeof(string));
            table.Columns.Add("Last Comment", typeof(string));
            foreach (appointment a in appointments)
            {
                int appId = a.AppointmentId;
                string desc = a.AppointmentDesc;
                String appointmentTime = a.AppointmentDate.ToShortTimeString();
                int typeId = a.AppointmentTypeId;
                string appointmentType = dbConn.getAppointmentTypeDesc(typeId);
                string persName = a.PersonName;
                string persSurname = a.PersonSurname;
                List<comment> comments = dbConn.getAppointmentCommentsById(appId);

                string lastComment = "";
                if (comments.Count > 0)
                {
                    lastComment = comments[comments.Count() - 1].CommentText;
                }

                table.Rows.Add(desc, persName, persSurname, appointmentTime, appointmentType, lastComment);
                pb.PerformStep();
            }
            return table;
        }

        //SEARCH
        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_panel.Visible)
            {
                search_panel.Visible = false;
                search_text.Text = "";
                this.populateTodayAppointments(this.todayAppointments);
                this.searchedTodayAppointments = new List<appointment>();

            }
            else
            {
                search_panel.Visible = true;
            }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            string text = this.search_text.Text;
            this.searchedTodayAppointments = new List<appointment>();

            Thread searchText;
            searchText = new Thread(
                () =>
                {
                    this.searchedTodayAppointments = Appointments.searchTodayAppointments(text, this.todayAppointments);
                    populateTodayAppointments(searchedTodayAppointments);
                    updateShowingText("Showing " + searchedTodayAppointments.Count().ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments");
                });
            searchText.Start();
        }

        private static List<appointment> searchTodayAppointments(string textToSearch, List<appointment> appointments)
        {
            List<appointment> searchedTodayAppointments = new List<appointment>();
            foreach (appointment a in appointments)
            {
                
                if (a.AppointmentDesc.Contains(textToSearch) || a.PersonId.Contains(textToSearch) || a.PersonName.Contains(textToSearch) || a.PersonSurname.Contains(textToSearch) || a.Tel.Contains(textToSearch) || a.Intermediary.Contains(textToSearch) || a.AdditionalPersonId.Contains(textToSearch) || a.AdditionalPersonName.Contains(textToSearch) || a.AdditionalPersonSurname.Contains(textToSearch) || a.AdditionalPersonTel.Contains(textToSearch))// || comments.Contains(textToSearch))
                {
                    searchedTodayAppointments.Add(a);
                }
            }
            return searchedTodayAppointments;
        }

        private void updateShowingText(string txt)
        {
            if (this.label13.InvokeRequired)
                label13.Invoke((MethodInvoker)delegate ()
                {
                    updateShowingText(txt);
                });
            else label13.Text = txt;
        }

        public void updateRemindersCount(string count = null)
        {
            if (count == null)
            {
                todayRemindersCount = dbConn.getTodayReminders().Count().ToString();
            }
            else todayRemindersCount = count;
            
            this.rem_label.Text = todayRemindersCount;
        }

        private void umportFromCsv_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb.Visible = true;
                int max = File.ReadAllLines(open.FileName).Count();
                pb.Minimum = 0;
                pb.Maximum = max;

                StreamReader sr = new StreamReader(open.FileName);
                
                bool firstRow = true;

                while(sr.Peek() >=0)
                {
                    string line = sr.ReadLine();
                    if (firstRow != true)
                    {
                        string[] rows = line.Split(',');
                        string title = rows[0];
                        DateTime schedule = Convert.ToDateTime(rows[1]);
                        int appointmentTypeId = 3;
                        string personId = rows[3];
                        string personName = rows[4];
                        string personSurname = rows[5];
                        string personTel = rows[6];
                        DateTime created = Convert.ToDateTime(rows[7]);
                        string intermediary = rows[8];
                        string additionalPersonId = rows[9];
                        string additionalPersonName = rows[10];
                        string additionalPersonSurname = rows[11];
                        string additionalPersonTel = rows[12];
                        int done = Int32.Parse(rows[13]);
                        int followUp = 0;

                        appointment a = new appointment(title, schedule, appointmentTypeId, personId, personName, personSurname, personTel, created, intermediary, additionalPersonId, additionalPersonName, additionalPersonSurname, additionalPersonTel, done, followUp, -1);
                        dbConn.SaveAppointment(a);
                        pb.PerformStep();
                    }

                    firstRow = false;
                }

                pbImportHider.Interval = progressVisibleTime;
                pbImportHider.Tick += pbImportHider_Tick;
                pbImportHider.Start();
            }
        }

        private void pbImportHider_Tick(object sender, EventArgs e)
        {
            pb.Visible = false;
            pbImportHider.Stop();
        }


        /*private void searchTodayAppointments(string textToSearch)
        {
            this.searchedTodayAppointments = new List<appointment>();
            foreach (appointment a in todayAppointments)
            {
                string comments = dbConn.getCommentsByAppointmentIdAsString(a.AppointmentId);
                if (a.AppointmentDesc.Contains(textToSearch) || a.PersonId.Contains(textToSearch) || a.PersonName.Contains(textToSearch) || a.PersonSurname.Contains(textToSearch) || a.Tel.Contains(textToSearch) || a.Intermediary.Contains(textToSearch) || a.AdditionalPersonId.Contains(textToSearch) || a.AdditionalPersonName.Contains(textToSearch) || a.AdditionalPersonSurname.Contains(textToSearch) || a.AdditionalPersonTel.Contains(textToSearch) || comments.Contains(textToSearch))
                {
                    this.searchedTodayAppointments.Add(a);
                }
            }

            this.populateTodayAppointments(searchedTodayAppointments);
            label13.Text = "Showing " + searchedTodayAppointments.Count().ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments";
        }*/

        /*public void populateTodayAppointments(List<appointment> appointments)
        {
            todayData.DataSource = null;
            todayData.Rows.Clear();
            foreach (appointment a in appointments)
            {
                string appointmentType = dbConn.getAppointmentTypeDesc(a.AppointmentTypeId);
                string lastComment = String.Empty;
                if (a.Comments.Count != 0)
                {
                    lastComment = a.Comments[a.Comments.Count() - 1].CommentText;
                }
                this.todayData.Rows.Add(a.AppointmentDesc, a.PersonName, a.PersonSurname, a.AppointmentDate.ToString("HH:mm"), appointmentType, lastComment);
            }
        }*/
    }
}
