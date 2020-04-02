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
    public partial class EditAppointment : Form
    {
        appointment a;
        database dbConn;
        string commentsString = "";

        public EditAppointment(appointment app)
        {
            InitializeComponent();
            this.a = app;
            dbConn = new database();
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            //Setting the text boxes text 
            title_label.Text = a.AppointmentDesc;
            created_text.Text = a.DateCreated.ToString("dd/MM/yyyy");
            statusShow_label.Text = a.Done == 1 ? "Done" : "In Progress";
            datePicker.Text = a.AppointmentDate.ToString("dd/MM/yyyy");
            timePicker.Text = a.AppointmentDate.ToString("HH:mm:ss");
            intermediary_text.Text = a.Intermediary;
            id1_text.Text = a.PersonId;
            name1_text.Text = a.PersonName;
            surname1_text.Text = a.PersonSurname;
            tel1_text.Text = a.Tel;

            id2_text.Text = a.AdditionalPersonId;
            name2_text.Text = a.AdditionalPersonName;
            surname2_text.Text = a.AdditionalPersonSurname;
            tel2_text.Text = a.AdditionalPersonTel;

            //Getting appointments types and selecting the proper index in the combo box
            List<string> appTypes = dbConn.getAllAppointmentTypes();
            string type = dbConn.getAppointmentTypeDesc(a.AppointmentTypeId);
            int index = appTypes.IndexOf(type);
            foreach (string appType in appTypes)
            {
                types_combo.Items.Add(appType);
            }
            types_combo.SelectedIndex = index;

            //if info for additional pers is entered make sure respective text field are enabled
            if (a.AdditionalPersonId != "" || a.AdditionalPersonName != "" || a.AdditionalPersonSurname != "" || a.AdditionalPersonTel != "")
            {
                addPerson_check.Checked = true;
            }

            //Populating comments Box
            List<comment> comments = dbConn.getAppointmentCommentsById(a.AppointmentId);
            foreach(comment c in comments)
            {
                commentsString += c.DateAdded.ToShortDateString() + ": " + c.CommentText + "\r\n";
            }
            comment_text.Text = commentsString;

            if(a.Followup != 1)
            {
                //Populating Follow Ups Box
                this.loadFollowUps();
            }

            //Getting Reminders
            this.loadReminders();

            //In case appointment is done dont allow to edit fields
            if (a.Done == 1)
            {
                this.disableAllFields();
                close_button.Visible = false;
                if(a.Followup != 1)
                {
                    followup_button.Visible = true;
                }
            }

            //In case appointment is followup show parent label
            if(a.Followup == 1)
            {
                parent_label.Visible = true;
                parent_link.Text = a.FollowUpParentId.ToString();
                parent_link.Visible = true;
            }
        }

        private void loadReminders()
        {
            int startPosition = 5;
            int endPosition = 10;
            reminders_panel.Controls.Clear();
            List<reminder> reminders = dbConn.getRemindersForAppointment(a.AppointmentId);
            upcomingRem_labe.Visible = reminders.Count() > 0 ? true : false;

            foreach (reminder rem in reminders)
            {
                Panel p = addRemPanel(rem, startPosition, endPosition);
                reminders_panel.Controls.Add(p);
                endPosition += 28;
            }
        }

        private void addPerson_check_CheckedChanged(object sender, EventArgs e)
        {
            if(addPerson_check.Checked == true)
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

        private void followup_button_Click(object sender, EventArgs e)
        {
            this.Close();
            AddAppointment aa = new AddAppointment(a, this);
            aa.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            //Closing appointment
            var confirmation = MessageBox.Show("You are not able to make changes afterwards!", "Are you sure you want to Close this Appointment ?",  MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                dbConn.closeAppointment(a.AppointmentId);
                this.disableAllFields();
                statusShow_label.Text = "Done";
                close_button.Visible = false;
                if(a.Followup == 0)
                {
                    followup_button.Visible = true;
                }
                string commentDescription = "Closed Appointment";
                dbConn.saveComment(commentDescription, 3, a.AppointmentId);

                this.addComment(commentDescription, DateTime.Now);
            }
        }

        private void disableAllFields()
        {
            datePicker.Enabled = false;
            timePicker.Enabled = false;
            intermediary_text.Enabled = false;
            types_combo.Enabled = false;
            id1_text.Enabled = false;
            name1_text.Enabled = false;
            surname1_text.Enabled = false;
            tel1_text.Enabled = false;
            addPerson_check.Checked = false;
            addPerson_check.Enabled = false;
            submitComment_button.Enabled = false;
            commentsubmit_text.Enabled = false;
            save_button.Enabled = false;
            setReminder_panel.Enabled = false;
            addRrem_button.Enabled = false;
        }

        private void parent_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            EditAppointment apps = new EditAppointment(dbConn.getAppointmentById(a.FollowUpParentId));
            apps.Show();
        }

        public void addComment(string text,DateTime date)
        {
            this.commentsString += date.ToShortDateString() + ": " + text + "\r\n";
            comment_text.Text = commentsString;
        }

        public void loadFollowUps()
        {
            int startPosition = 10;
            int endPosition = 0;
            followsupItems_panel.Controls.Clear();
            List<appointment> followups = new List<appointment>();
            followups = dbConn.getFollowUpsForAppointment(a.AppointmentId);

            foreach (appointment fu in followups)
            {
                Panel p = addFUPanel(fu.AppointmentId, fu.AppointmentDate, fu.Done, startPosition, endPosition);
                followsupItems_panel.Controls.Add(p);
                endPosition += 30;
            }
        }

        private Panel addFUPanel(int appointmentId, DateTime scheduleDate, int status, int startPosition, int endPosition)
        {
            Panel p = new Panel();
            p.Location = new Point(startPosition, endPosition);
            p.Width = 235;
            p.Height = 25;
            p.BackColor = status == 1 ? Color.LightGreen : Color.Orange;

            LinkLabel appId = new LinkLabel();
            appId.Width = 30;
            appId.Height = 25;
            appId.Text = appointmentId.ToString();
            appId.Location = new Point(15);
            appId.TextAlign = ContentAlignment.MiddleRight;
            appId.Click += (s, e) =>
            {
                this.Close();
                EditAppointment ea = new EditAppointment(dbConn.getAppointmentById(appointmentId));
                ea.Show();
            };
            p.Controls.Add(appId);

            Label schedule = new Label();
            schedule.Text = scheduleDate.ToShortDateString();
            schedule.Width = 30;
            schedule.Height = 25;
            schedule.Location = new Point(60);
            schedule.TextAlign = ContentAlignment.MiddleCenter;
            p.Controls.Add(schedule);

            Label stat = new Label();
            string txt = status == 1 ? "Done" : "In Progress";
            stat.Text = txt;
            schedule.Width = 100;
            schedule.Height = 25;
            stat.Location = new Point(170);
            stat.TextAlign = ContentAlignment.MiddleLeft;
            p.Controls.Add(stat);
            return p;
        }

        private Panel addRemPanel(reminder r , int startPosition, int endPosition)
        {
            Panel p = new Panel();
            p.Location = new Point(startPosition, endPosition);
            p.Width = 230;
            p.Height = 23;
            p.BackColor = Color.Transparent;

            Label desc = new Label();
            desc.Location = new Point(10, 0);
            desc.Width = 167;
            desc.Height = 23;
            desc.Text = r.ReminderMessage;
            p.Controls.Add(desc);

            Label date = new Label();
            date.Text = r.ReminderDate.ToShortDateString();
            date.Width = 65;
            date.Height = 32;
            date.Location = new Point(167, 0);
            p.Controls.Add(date);

            return p;
        }

        private void submitComment_button_Click(object sender, EventArgs e)
        {
            string commentText = commentsubmit_text.Text;
            dbConn.saveComment(commentText, 1, a.AppointmentId);
            commentsubmit_text.Text = "";
            commentsString += DateTime.Now.ToShortDateString() + ": " + commentText + "\r\n";
            comment_text.Text = commentsString;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (id1_text.Text != "" && name1_text.Text != "" && surname1_text.Text != "" && tel1_text.Text != "")
            {
                var confirmation = MessageBox.Show("Are you sure?", "You are Updating Appointment Information", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string desc = a.AppointmentDesc;
                    string date = datePicker.Text;
                    string time = timePicker.Text;
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
                    string intermediary = intermediary_text.Text.Replace("'", "");
                    DateTime created = a.DateCreated;
                    int done = dbConn.getAppointmentStatusById(a.AppointmentId);
                    int followUp = a.Followup;
                    int parentId = a.FollowUpParentId;

                    appointment app = new appointment(a.AppointmentId, desc, datetime, appointmentTypeId, person1Id, person1Name, person1Surname, person1Tel, created, intermediary, person2Id, person2Name, person2Surname, person2Tel, done, followUp, parentId);
                    dbConn.UpdateAppointment(app);

                    string comment = "Changed Appointment Details";
                    dbConn.saveComment(comment, 4, a.AppointmentId);
                    commentsString += DateTime.Now.ToShortDateString() + ": " + comment + "\r\n";
                    comment_text.Text = commentsString;


                    saved_label.Visible = true;
                    hide_success_label.Interval = 3000;
                    hide_success_label.Tick += hide_success_label_Tick;
                    hide_success_label.Start();
                }
            }
            else
            {
                if (id1_text.Text == "") required_id.Visible = true;
                if (name1_text.Text == "") required_name.Visible = true;
                if (surname1_text.Text == "") required_surname.Visible = true;
                if (tel1_text.Text == "") required_tel.Visible = true;

                error_label.Visible = true;
                hide_error_label.Interval = 3000;
                hide_error_label.Tick += hide_error_label_Tick;
                hide_error_label.Start();
            }
            
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

        private void addRrem_button_Click(object sender, EventArgs e)
        {
            DateTime remDate = reminder_datetime.Value;
            string message = remMessage_text.Text == "" ? a.AppointmentDesc : remMessage_text.Text;
            reminder rem = new reminder(remDate, message, a.AppointmentId, 0);
            dbConn.saveReminder(rem);

            remMessage_text.Text = "";
            reminder_datetime.Value = DateTime.Now;
            this.loadReminders();
        }
    }
}
