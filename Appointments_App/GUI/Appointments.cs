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
        List<appointment> searchedTodayAppointments = new List<appointment>();
        string todayRemindersCount;
        public int TodayAppointmentsAll;

        public Appointments()
        {
            InitializeComponent();
            dbConn = new database();
            this.todayAppointments = dbConn.getTodayAppointments();
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
            Export.exportAppointments(this.todayAppointments, appTypes, "Today Appointments");
        }

        

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.todayAppointments = dbConn.getTodayAppointments();
            TodayAppointmentsAll = todayAppointments.Count();
            this.label13.Text = "Showing " + TodayAppointmentsAll.ToString() + " out of " + dbConn.getCountAllAppointments().ToString() + " Appointments";
            this.populateTodayAppointments(this.todayAppointments);
            this.updateRemindersCount();

            if(todayAppointments.Count() > 0)
            {
                noAppointments_labe.Hide();
            }
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

        /*public void setTodayReminderCount(string count)
        {
            rem_label.Refresh();
            this.rem_label.Text = count;
        }*/

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
