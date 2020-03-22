﻿using Appointments_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments_App.GUI
{
    public partial class Filter : Form
    {
        database dbConn;
        DateTime scheduledMin;
        DateTime createdMin;

        public Filter()
        {
            InitializeComponent();
            dbConn = new database();

            scheduledMin = Convert.ToDateTime(schedule_datetime1.Value);
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            List<string> allTypes = dbConn.getAllAppointmentTypes();
            allTypes.Insert(0, "All");
            for(int i = 0; i < allTypes.Count(); i++)
            {
                type_combo.Items.Add(allTypes[i]);
            }
            type_combo.SelectedIndex = 0;
            status_combo.SelectedIndex = 0;
            scheduleDate_combo.SelectedIndex = 0;
            createdDate_combo.SelectedIndex = 0;
            allInt_radio.Checked = true;

            schedule_datetime2.MinDate = scheduledMin;
            created_datetime2.MinDate = createdMin;
        }

        private void statusDate_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(scheduleDate_combo.SelectedIndex == 0)
            {
                schedule_datetime1.Enabled = false;
                schedule_datetime2.Enabled = false;
            }
            else if(scheduleDate_combo.SelectedIndex == 1 || scheduleDate_combo.SelectedIndex == 2 || scheduleDate_combo.SelectedIndex == 3)
            {
                schedule_datetime1.Enabled = true;
                schedule_datetime2.Enabled = false;
            }
            else
            {
                schedule_datetime1.Enabled = true;
                schedule_datetime2.Enabled = true;
            }
        }

        private void createdDate_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (createdDate_combo.SelectedIndex == 0)
            {
                created_datetime1.Enabled = false;
                created_datetime2.Enabled = false;
            }
            else if (createdDate_combo.SelectedIndex == 1 || createdDate_combo.SelectedIndex == 2 || createdDate_combo.SelectedIndex == 3)
            {
                created_datetime1.Enabled = true;
                created_datetime2.Enabled = false;
            }
            else
            {
                created_datetime1.Enabled = true;
                created_datetime2.Enabled = true;
            }
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            status_combo.SelectedIndex = 0;
            scheduleDate_combo.SelectedIndex = 0;
            type_combo.SelectedIndex = 0;
            createdDate_combo.SelectedIndex = 0;
            allInt_radio.Checked = true;
            yesInt_radio.Checked = false;
            noInt_radio.Checked = false;
        }

        private void yesInt_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(yesInt_radio.Checked == true)
            {
                allInt_radio.Checked = false;
                noInt_radio.Checked = false;
                yesInt_radio.Checked = true;
            }
        }

        private void noInt_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(noInt_radio.Checked == true)
            {
                allInt_radio.Checked = false;
                noInt_radio.Checked = true;
                yesInt_radio.Checked = false;
            }
        }

        private void allInt_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(allInt_radio.Checked == true)
            {
                allInt_radio.Checked = true;
                noInt_radio.Checked = false;
                yesInt_radio.Checked = false;
            }
        }

        private void schedule_datetime1_ValueChanged(object sender, EventArgs e)
        {
            scheduledMin = Convert.ToDateTime(schedule_datetime1.Text);
            schedule_datetime2.MinDate = scheduledMin;
        }

        private void created_datetime1_ValueChanged(object sender, EventArgs e)
        {
            createdMin = Convert.ToDateTime(created_datetime1.Value);
            created_datetime2.MinDate = createdMin;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Appointments WHERE ";

            string statusQuery = "";
            string status = status_combo.Text;
            if(status == "Done")
            {
                statusQuery = "done = 1";
            }
            else if(status == "In Progress")
            {
                statusQuery = "done = 0";
            }
            

            string scheduleOperator = scheduleDate_combo.Text;
            string scheduleDateQuery = "";
            switch (scheduleOperator)
            {
                case "After": scheduleDateQuery = "appointment_date > #" + schedule_datetime1.Value.ToShortDateString() + "#"; break;
                case "Before": scheduleDateQuery = "appointment_date < #" + schedule_datetime1.Value.ToShortDateString() + "#"; break;
                case "On": scheduleDateQuery = "appointment_date = #" + schedule_datetime1.Value.ToShortDateString() + "#"; break;
                case "Between": scheduleDateQuery = "appointment_date < #" + schedule_datetime2.Value.ToShortDateString() + "# and appointment_date > #" + schedule_datetime1.Value.ToShortDateString() + "#"; break;
            }

            string allQuery = query + scheduleDateQuery;
        }
    }
}