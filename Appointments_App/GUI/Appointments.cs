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
        todayAppointments ta;
        allAppointments aa;

        DataTable dtTodayAppoitnemts;
        DataTable dtAllAppointments;
        DataTable searchedTodayAppointments = new DataTable();
        DataTable searchedAllAppointments = new DataTable();
        public DataTable filteredAppointments = new DataTable();
        string todayRemindersCount;

        int GlobalAppointmentsCount;
        int TodayAppointmentsCount;
        int AllAppointmentsCount;
        int progressVisibleTime = 1500; //ms

        public Appointments()
        {
            InitializeComponent();
            dbConn = new database();
            this.dtAllAppointments = dbConn.getAllAppointmentsAsDataTable();
            this.dtTodayAppoitnemts = dbConn.getTodayAppointmentsDataTable();

            GlobalAppointmentsCount = dbConn.getCountAllAppointments();
            TodayAppointmentsCount = dtTodayAppoitnemts.Rows.Count;
            AllAppointmentsCount = dtAllAppointments.Rows.Count;

            date_label.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            allDate_label.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            ta = new todayAppointments(this);
            aa = new allAppointments(this);
        }

        //////////////////////////// ON LOAD ////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            aa.populateAllAppointments(this.dtAllAppointments);
            ta.populateTodayAppointments(this.dtTodayAppoitnemts);

            if (TodayAppointmentsCount == 0)
            {
                noAppointments_labe.Visible = true;
            }

            this.updateCounterText(counterToday_label, this.TodayAppointmentsCount);
            this.updateCounterText(counterAll_label, this.AllAppointmentsCount);
            this.updateRemindersCount();
        }
        //////////////////////////// END ON LOAD ////////////////////////////


        //////////////////////////// EDIT APPOINTMENT ////////////////////////////
        private void todayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            appointment app;
            if(index > -1)
            {
                if(this.searchedTodayAppointments.Rows.Count != 0)
                {
                    string title = searchedTodayAppointments.Rows[index]["title"] as string;
                    app = dbConn.getAppointmentByTitle(title);
                }
                else
                {
                    string title = dtTodayAppoitnemts.Rows[index]["title"] as string;
                    app = dbConn.getAppointmentByTitle(title);
                }
                EditAppointment ea = new EditAppointment(app);
                ea.ShowDialog();
            }
        }

        private void allAppoitnmentsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            appointment app;
            if (index > -1)
            {
                if (this.filteredAppointments.Rows.Count != 0)
                {
                    string title = filteredAppointments.Rows[index]["title"] as string;
                    app = dbConn.getAppointmentByTitle(title);
                }
                else if (this.searchedAllAppointments.Rows.Count != 0)
                {
                    string title = searchedAllAppointments.Rows[index]["title"] as string;
                    app = dbConn.getAppointmentByTitle(title);
                }
                else
                {
                    string title = dtAllAppointments.Rows[index]["title"] as string;
                    app = dbConn.getAppointmentByTitle(title);
                }
                EditAppointment ea = new EditAppointment(app);
                ea.ShowDialog();
            }
        }
        //////////////////////////// end EDIT APPOINTMENT ////////////////////////////


        //////////////////////////// REFRESH ////////////////////////////
        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.refreshData();

            if(TodayAppointmentsCount > 0)
            {
                noAppointments_labe.Hide();
            }
        }

        private void allRefresh_button_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        private void refreshData()
        {
            this.dtTodayAppoitnemts = dbConn.getTodayAppointmentsDataTable();
            this.dtAllAppointments = dbConn.getAllAppointmentsAsDataTable();

            TodayAppointmentsCount = dtTodayAppoitnemts.Rows.Count;
            AllAppointmentsCount = dtAllAppointments.Rows.Count;

            ta.populateTodayAppointments(dtTodayAppoitnemts);
            aa.populateAllAppointments(dtAllAppointments);

            this.GlobalAppointmentsCount = dbConn.getCountAllAppointments();
            this.updateCounterText(counterToday_label, TodayAppointmentsCount);
            this.updateCounterText(counterAll_label, AllAppointmentsCount);
            this.updateRemindersCount();
        }
        //////////////////////////// END REFRESH ////////////////////////////

        //////////////////////////// ADD APPOINTMENT ////////////////////////////
        private void addAppointment_button_Click(object sender, EventArgs e)
        {
            AddAppointment aa = new AddAppointment();
            aa.Show();
        }

        private void allAddApp_button_Click(object sender, EventArgs e)
        {
            AddAppointment aa = new AddAppointment();
            aa.Show();
        }
        //////////////////////////// END ADD APPOINTMENT ////////////////////////////

        //////////////////////////// VIEW REMINDERS ////////////////////////////
        private void reminders_button_Click(object sender, EventArgs e)
        {
            Reminders rem = new Reminders(this);
            rem.ShowDialog();
        }

        private void allReminders_button_Click(object sender, EventArgs e)
        {
            Reminders rem = new Reminders(this);
            rem.ShowDialog();
        }

        public void updateRemindersCount(string count = null)
        {
            if (count == null)
            {
                todayRemindersCount = dbConn.getTodayReminders().Count().ToString();
            }
            else todayRemindersCount = count;

            this.allRemindersCount_label.Text = this.rem_label.Text = todayRemindersCount;
        }
        //////////////////////////// END VIEW REMINDERS ////////////////////////////

        //////////////////////////// SEARCH ////////////////////////////
        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_panel.Visible)
            {
                search_panel.Visible = false;
                search_text.Text = "";
                ta.populateTodayAppointments(this.dtTodayAppoitnemts);
                this.searchedTodayAppointments = new DataTable();
            }
            else
            {
                search_panel.Visible = true;
            }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            string text = this.search_text.Text;
            this.searchedTodayAppointments = dbConn.searchTodayAppointmets(text);
            ta.populateTodayAppointments(searchedTodayAppointments);
            updateCounterText(counterToday_label, searchedTodayAppointments.Rows.Count);


            /*DataTable searched = dtTodayAppoitnemts.AsEnumerable()
                .Where(row => row.Field<String>("Description") == text)
                .CopyToDataTable()*/
        }

        private void clearSerach_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_text.Text = "";
            ta.populateTodayAppointments(this.dtTodayAppoitnemts);
            this.updateCounterText(counterToday_label, TodayAppointmentsCount);
            this.searchedTodayAppointments = new DataTable();
        }

        private void allSearch_button_Click(object sender, EventArgs e)
        {
            if (allSearch_panel.Visible)
            {
                allSearch_panel.Visible = false;
                allSearch_text.Text = "";
                aa.populateAllAppointments(this.dtAllAppointments);
                this.searchedAllAppointments = new DataTable();
            }
            else
            {
                allSearch_panel.Visible = true;
            }
        }

        private void allSearch_text_TextChanged(object sender, EventArgs e)
        {
            string text = this.allSearch_text.Text;
            this.searchedAllAppointments = dbConn.searchAllAppointmets(text);
            aa.populateAllAppointments(searchedAllAppointments);
            updateCounterText(counterAll_label, searchedAllAppointments.Rows.Count);
        }

        private void allSearchClear_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allSearch_text.Text = "";
            aa.populateAllAppointments(this.dtAllAppointments);
            this.updateCounterText(counterAll_label, AllAppointmentsCount);
            this.searchedAllAppointments = new DataTable();
        }
        //////////////////////////// END SEARCH ////////////////////////////        

        //////////////////////////// IMPORT/EXPORT ////////////////////////////
        private void saveToCsv_button_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> appTypes = dbConn.getAllAppointmentTypesDict();
            //Export.exportAppointments(this.todayAppointments, appTypes, "Today Appointments", pb);

        }

        private void umportFromCsv_button_Click(object sender, EventArgs e)
        {
            Import.importAppointments(dbConn);
        }
        //////////////////////////// END IMPORT/EXPORT ////////////////////////////

        private void pbImportHider_Tick(object sender, EventArgs e)
        {
            pb.Visible = false;
            pbImportHider.Stop();
        }

        public void updateCounterText(Label l, int showingCount)
        {
            l.Text = "Showing " + showingCount.ToString() + " out of " + this.GlobalAppointmentsCount + " Appointments";
        }

        /*private void filter_button_Click(object sender, EventArgs e)
        {
            Filter fil = new Filter();
            fil.ShowDialog();
        }*/

        private void allFilter_button_Click(object sender, EventArgs e)
        {
            Filter fil = new Filter(this);
            fil.Show();
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

        /*public DataTable getTodayAppointments()
        {
            DataTable dtTodayAppoitnemts = dtAllAppointments.AsEnumerable()
                .Where(row => row.Field<DateTime>("Schedule_Date").ToShortDateString() == DateTime.Now.ToShortDateString())
                .CopyToDataTable();

            var query = from appointment in dtAllAppointments.AsEnumerable()
                        where appointment.Field<DateTime>("Schedule_Date").ToShortDateString() == DateTime.Now.ToShortDateString()
                        //where Convert.ToDateTime(appointment["Schedule_Date"]).ToShortDateString() == DateTime.Now.ToShortDateString()
                        select new
                         {
                            
                             Title = appointment.Field<string>("Title"),
                             Name = appointment.Field<string>("Name")
                         };

            //DataTable td = query.CopyToDataTable();

            return dtTodayAppoitnemts;
        }*/
    }
}
