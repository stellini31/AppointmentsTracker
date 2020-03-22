using Appointments_App.Classes;
using Appointments_App.Database;
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
    public partial class AddAppointment : Form
    {
        database dbConn;

        public AddAppointment()
        {
            InitializeComponent();
            dbConn = new database();
            saved_label.Visible = false;
            error_label.Visible = false;
            addReminder_check.Checked = false;
            datePicker.MinDate = DateTime.Now;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (addPerson_check.Checked)
            {
                id2_text.Enabled = true;
                name2_text.Enabled = true;
                surname2_text.Enabled = true;
                tel2_text.Enabled = true;
            }
            else
            {
                id2_text.Enabled = false;
                name2_text.Enabled = false;
                surname2_text.Enabled = false;
                tel2_text.Enabled = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string appointmentDesc = description_text.Text.Replace("'", "");
            string date = datePicker.Text;
            string time = TimePicker.Text;
            DateTime datetime = Convert.ToDateTime(date + " " + time);
            int appointmentTypeId = dbConn.getAppointmentTypeId(types_combo.SelectedItem.ToString());
            string person1Id = id1_text.Text.Replace("'", "");
            string person1Name = name1_text.Text.Replace("'", "");
            string person1Surname = surname1_text.Text.Replace("'", "");
            string person1Tel = tel1_text.Text.Replace("'", "");
            string person2Id = id2_text.Text.Replace("'", "");
            string person2Name = name2_text.Text.Replace("'", "");
            string person2Surname = surname2_text.Text.Replace("'", "");
            string person2Tel = tel2_text.Text.Replace("'", "");
            DateTime appointmentCreated = DateTime.Now;
            string intermediary = intermediary_text.Text.Replace("'", ""); 
            int done = 0;

            if(description_text.Text != "" && description_text.Text != "" && id1_text.Text != "" &&  name1_text.Text != "" && surname1_text.Text != "" && tel1_text.Text != "")
            {
                appointment app = new appointment(appointmentDesc, datetime, appointmentTypeId, person1Id, person1Name, person1Surname, person1Tel, appointmentCreated, intermediary, person2Id, person2Name, person2Surname, person2Tel, done);
                dbConn.SaveAppointment(app);
                int appointmentId = dbConn.getLastAppointmentId();
                string reminderMessage = remMessage_text.Text.Replace("'", "");

                if (addReminder_check.Checked)
                {
                    reminder rem = new reminder(Convert.ToDateTime(reminder_datetime.Text), reminderMessage, appointmentId, 0);
                    dbConn.saveReminder(rem);
                }

                saved_label.Visible = true;
                hide_success_label.Interval = 3000;
                hide_success_label.Tick += hide_success_label_Tick;
                hide_success_label.Start();

                description_text.Text = "";
                id1_text.Text = "";
                name1_text.Text = "";
                surname1_text.Text = "";
                tel1_text.Text = "";
                id2_text.Text = "";
                name2_text.Text = "";
                surname2_text.Text = "";
                tel2_text.Text = "";
                intermediary_text.Text = "";

                id2_text.Enabled = false;
                name2_text.Enabled = false;
                surname2_text.Enabled = false;
                tel2_text.Enabled = false;
                addPerson_check.Checked = false;
                string commentText = comment_text.Text.Replace("'", "");
                if (commentText != "")
                {
                    dbConn.saveComment(commentText, 1);
                }
                comment_text.Text = "";
                remMessage_text.Text = "";
                addReminder_check.Checked = false;

            }
            else 
            {
                error_label.Visible = true;
                hide_error_label.Interval = 3000;
                hide_error_label.Tick += hide_error_label_Tick;
                hide_error_label.Start();
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            List<string> Types = dbConn.getAllAppointmentTypes();

            foreach(string type in Types)
            {
                types_combo.Items.Add(type);
            }

            types_combo.SelectedIndex = 0;
        }

     

        private void hide_success_label_Tick(object sender, EventArgs e)
        {
            saved_label.Visible = false;
            hide_success_label.Stop();
        }

        private void hide_error_label_Tick(object sender, EventArgs e)
        {
            error_label.Visible = false;
            hide_error_label.Stop();
        }

        private void addReminder_check_CheckedChanged(object sender, EventArgs e)
        {
            if (addReminder_check.Checked)
            {
                reminder_panel.Height = 183;
            }
            else
            {
                reminder_panel.Height = 45;
            }
        }
    }
}
