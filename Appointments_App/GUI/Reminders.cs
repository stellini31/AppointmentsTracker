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
    public partial class Reminders : Form
    {
        database dbConn;
        Appointments app;
        List<reminder> todayReminders;

        public Reminders(Appointments a)
        {
            InitializeComponent();
            dbConn = new database();
            this.app = a;
        }

        private void Reminders_Load(object sender, EventArgs e)
        {
            int startPosition = 20;
            int endPosition = 50;
            todayReminders = dbConn.getTodayReminders();
            foreach(reminder rem in todayReminders)
            {
                string reminderMessage = rem.ReminderMessage;

                if(rem.ReminderMessage == "")
                {
                    reminderMessage = "Appointment: " + dbConn.getAppointmentById(rem.AppointmentId).AppointmentDesc;
                }

                Panel p = addPanel(rem.AppointmentId, rem.ReminderId, reminderMessage, startPosition, endPosition);
                reminders_panel.Controls.Add(p);
                endPosition += 60;
            }

        }

        Panel addPanel(int appointmentId, int reminderId, string reminderMessage, int start, int end)
        {
            Panel p = new Panel();
            p.Name = appointmentId.ToString() + "panel";
            p.ForeColor = SystemColors.InactiveBorder;
            p.BackColor = SystemColors.InactiveBorder;
            p.Width = 750;
            p.Height = 45;
            p.Location = new Point(start, end);

            Label l = new Label();
            l.Name = appointmentId.ToString();
            l.Width = 550;
            l.Height = 43;
            l.BackColor = Color.Transparent;
            l.ForeColor = Color.Black;
            l.Font = new Font("Microsoft Sans Serif", 10);
            l.Text = reminderMessage;
            l.Location = new Point(20, 0);
            l.TextAlign = ContentAlignment.MiddleLeft;
            p.Controls.Add(l);

            Button b = new Button();
            b.Width = 60;
            b.Height = 30;
            b.Name = reminderId.ToString();
            b.Location = new Point(650, (p.Height - b.Height) / 2);
            b.FlatStyle = FlatStyle.Flat;
            b.Text = "dismiss";
            b.BackColor = SystemColors.InactiveBorder;
            b.ForeColor = Color.Black;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.Click += (s, e) =>
            {
                int remindId = Int32.Parse(b.Name.ToString());
                dbConn.dismissReminder(remindId);
                p.Enabled = false;
                string count = (todayReminders.Count() - 1).ToString();
                app.setTodayReminderCount(count);
               // app.UpdateLabelValue(count);

            };
            p.Controls.Add(b);

            Label line = new Label();
            line.Height = 1;
            line.Width = 750;
            line.Dock = DockStyle.Bottom;
            line.BackColor = Color.Black;
            line.Location = new Point(0, 45);
            p.Controls.Add(line);

            return p;
        }

        private void dismissall_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dbConn.dismissAllTodayReminders();
            string count = 0.ToString();
            app.setTodayReminderCount(count);
            //app.UpdateLabelValue(count);
            this.Close();
        }

    }
}
