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
        Filter fil;

        DataTable dtTodayAppoitnemts;
        DataTable dtAllAppointments;
        DataTable searchedTodayAppointments = new DataTable();
        DataTable searchedAllAppointments = new DataTable();
        public DataTable filteredAppointments = new DataTable();
        string todayRemindersCount;

        int GlobalAppointmentsCount;
        int TodayAppointmentsCount;
        int AllAppointmentsCount;
        bool higlighted = false;

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
            fil = new Filter(this);
        }

        //////////////////////////// ON LOAD ////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            this.populateAppointments(this.allAppoitnmentsData, this.dtAllAppointments);
            this.populateAppointments(this.todayData, this.dtTodayAppoitnemts);

            if (TodayAppointmentsCount == 0)
            {
                noAppointments_labe.Visible = true;
            }

            this.updateCounterText(counterToday_label, this.TodayAppointmentsCount);
            this.updateCounterText(counterAll_label, this.AllAppointmentsCount);
            this.updateRemindersCount();

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
        //////////////////////////// END EDIT APPOINTMENT ////////////////////////////

        //////////////////////////// POPULATE DATA TABLES ////////////////////////////
        public void populateAppointments(DataGridView dataView, DataTable allAppointments)
        {
            dataView.DataSource = allAppointments;
            dataView.Columns[0].Width = 300;
            dataView.Columns[1].Width = 150;
            dataView.Columns[2].Width = 150;
            dataView.Columns[3].Width = 150;
            dataView.Columns[4].Width = 150;
            dataView.Columns[5].Width = 350;
            dataView.Columns[6].Width = 0;
        }
        //////////////////////////// END POPULATE DATA TABLES ////////////////////////////

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

            this.populateAppointments(this.todayData, dtTodayAppoitnemts);
            this.populateAppointments(this.allAppoitnmentsData, dtAllAppointments);

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
                this.populateAppointments(this.todayData, this.dtTodayAppoitnemts);
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
            this.populateAppointments(this.todayData, searchedTodayAppointments);
            updateCounterText(counterToday_label, searchedTodayAppointments.Rows.Count);
        }

        private void clearSerach_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_text.Text = "";
            this.populateAppointments(this.todayData, this.dtTodayAppoitnemts);
            this.updateCounterText(counterToday_label, TodayAppointmentsCount);
            this.searchedTodayAppointments = new DataTable();
        }

        private void allSearch_button_Click(object sender, EventArgs e)
        {
            if (allSearch_panel.Visible)
            {
                allSearch_panel.Visible = false;
                allSearch_text.Text = "";
                this.populateAppointments(this.allAppoitnmentsData, this.dtAllAppointments);
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
            this.populateAppointments(this.allAppoitnmentsData, searchedAllAppointments);
            updateCounterText(counterAll_label, searchedAllAppointments.Rows.Count);
            this.clearFilter();
        }

        private void allSearchClear_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allSearch_text.Text = "";
            this.populateAppointments(this.allAppoitnmentsData, this.dtAllAppointments);
            this.updateCounterText(counterAll_label, AllAppointmentsCount);
            this.searchedAllAppointments = new DataTable();
        }
        //////////////////////////// END SEARCH ////////////////////////////        

        //////////////////////////// IMPORT/EXPORT ////////////////////////////
        private void saveToCsv_button_Click(object sender, EventArgs e)
        {
            Export.exportAppointments(dbConn.getTodayAppointmentsAllData(), "Today Appointments");
        }

        private void umportFromCsv_button_Click(object sender, EventArgs e)
        {
            Import.importAppointments(dbConn);
        }

        private void allExport_button_Click(object sender, EventArgs e)
        {
            DataTable appointmentss = new DataTable();
            string fileName = String.Empty;
            if (filteredAppointments.Rows.Count > 0)
            {
                fileName = "Filtered Appointments";
                string queryUsed = fil.allQuery;
                appointmentss = dbConn.getAllAppointmentsAllData(queryUsed);
            }
            else
            {
                fileName = "All Appointments";
                appointmentss = dbConn.getAllAppointmentsAllData();
            }
            Export.exportAppointments(appointmentss, fileName);
        }

        private void allImport_button_Click(object sender, EventArgs e)
        {
            Import.importAppointments(dbConn);
        }
        //////////////////////////// END IMPORT/EXPORT ////////////////////////////

        //////////////////////////// FILTER ////////////////////////////
        private void allFilter_button_Click(object sender, EventArgs e)
        {
            if (fil.Visible == true) fil.Visible = false;
            else fil.Visible = true;
        }

        private void clearFilter_button_Click(object sender, EventArgs e)
        {
            this.populateAppointments(this.allAppoitnmentsData, dtAllAppointments);
            updateCounterText(counterAll_label, dtAllAppointments.Rows.Count);
            clearFilter();
        }

        public void clearFilter()
        {
            this.clearFilter_button.Visible = false;
            this.filteredAppointments = new DataTable();
        }
        //////////////////////////// END FILTER ////////////////////////////

        private void pbImportHider_Tick(object sender, EventArgs e)
        {
            pb.Visible = false;
            pbImportHider.Stop();
        }


        public void updateCounterText(Label l, int showingCount)
        {
            l.Text = "Showing " + showingCount.ToString() + " out of " + this.GlobalAppointmentsCount + " Appointments";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1 && !higlighted)
            {
                foreach (DataGridViewRow row in allAppoitnmentsData.Rows)
                {
                    string title = row.Cells["Title"].Value.ToString();
                    DateTime Schedule = Convert.ToDateTime(row.Cells["Schedule"].Value.ToString());
                    if(Schedule.Date < DateTime.Now.Date && Int32.Parse(row.Cells["done"].Value.ToString()) == 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    //dataView.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                    
                }
                
            }
        }
    }
}
