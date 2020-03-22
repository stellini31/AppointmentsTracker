using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Classes
{
    public class reminder
    {
        private int reminderId;
        private DateTime reminderDate;
        private string reminderMessage;
        int appointmentId;
        int dismissed;

        public reminder(int reminderId, DateTime reminderDate, string reminderMessage, int appointmentId, int dismissed)
        {
            this.ReminderId = reminderId;
            this.ReminderDate = reminderDate;
            this.ReminderMessage = reminderMessage;
            this.AppointmentId = appointmentId;
            this.Dismissed = dismissed;
        }

        public reminder(DateTime reminderDate, string reminderMessage, int appointmentId, int dismissed)
        {
            this.ReminderDate = reminderDate;
            this.ReminderMessage = reminderMessage;
            this.AppointmentId = appointmentId;
            this.Dismissed = dismissed;
        }

        public int ReminderId { get => reminderId; set => reminderId = value; }
        public DateTime ReminderDate { get => reminderDate; set => reminderDate = value; }
        public string ReminderMessage { get => reminderMessage; set => reminderMessage = value; }
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public int Dismissed { get => dismissed; set => dismissed = value; }
    }
}
