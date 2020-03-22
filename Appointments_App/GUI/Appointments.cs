using Appointments_App.Classes;
using Appointments_App.Database;
using Appointments_App.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments_App
{
    public partial class Appointments : Form
    {
        database dbConn;
        List<appointment> todayAppointments;
        List<appointment> searchedTodayAppointments = new List<appointment>();
        string todayRemindersCount;

        public Appointments()
        {
            InitializeComponent();
            dbConn = new database();
            this.todayAppointments = dbConn.getTodayAppointments();
            todayRemindersCount = dbConn.getTodayReminders().Count().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////////////TODAY APPOINTMENTS////////////////////
            this.populateTodayAppointments(this.todayAppointments);
            ////////////////////END TODAY APPOINTMENTS////////////////////

            this.setTodayReminderCount(todayRemindersCount);
        }

        //delegate void UpdateLabelDelegate(string message);

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
            SaveFileDialog savetoCSV = new SaveFileDialog();
            savetoCSV.Title = "Save Appointments as CSV";
            savetoCSV.FileName = "Appointments " + DateTime.Now;
            savetoCSV.Filter = "CSV File|*.csv";
            string initPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            savetoCSV.InitialDirectory = initPath;
            savetoCSV.RestoreDirectory = true;
            savetoCSV.ShowDialog();

            if (savetoCSV.FileName != "")
            {
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.todayAppointments = dbConn.getTodayAppointments();
            this.populateTodayAppointments(this.todayAppointments); 
        }

        private void addAppointment_button_Click(object sender, EventArgs e)
        {
            AddAppointment aa = new AddAppointment();
            aa.Show();
        }

        public void populateTodayAppointments(List<appointment> appointments)
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
        }

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

        private void searchTodayAppointments(string textToSearch)
        {
            this.searchedTodayAppointments = new List<appointment>();
            foreach (appointment a in todayAppointments)
            {
                string comments = dbConn.getCommentsByAppointmentId(a.AppointmentId);
                if (a.AppointmentDesc.Contains(textToSearch) || a.PersonId.Contains(textToSearch) || a.PersonName.Contains(textToSearch) || a.PersonSurname.Contains(textToSearch) || a.Tel.Contains(textToSearch) || a.Intermediary.Contains(textToSearch) || a.AdditionalPersonId.Contains(textToSearch) || a.AdditionalPersonName.Contains(textToSearch) || a.AdditionalPersonSurname.Contains(textToSearch) || a.AdditionalPersonTel.Contains(textToSearch) || comments.Contains(textToSearch))
                {
                    this.searchedTodayAppointments.Add(a);
                }
            }

            this.populateTodayAppointments(searchedTodayAppointments);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_text.Text = "";
            this.populateTodayAppointments(this.todayAppointments);
            this.searchedTodayAppointments = new List<appointment>();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            string text = this.search_text.Text;
            this.searchTodayAppointments(text);
        }

        private void reminders_button_Click(object sender, EventArgs e)
        {
            Reminders rem = new Reminders(this);
            rem.ShowDialog();
        }

        public void setTodayReminderCount(string count)
        {
            rem_label.Refresh();
            this.rem_label.Text = count;
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            Filter fil = new Filter();
            fil.ShowDialog();
        }
    }
}
