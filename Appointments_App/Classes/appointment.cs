using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Classes
{
    public class appointment
    {
        private int appointmentId;
        private string appointmentDesc;
        private DateTime appointmentDate;
        private int appointmentTypeId;
        private string personId;
        private string personName;
        private string personSurname;
        private string tel;
        private DateTime dateCreated;
        private string intermediary;
        private string additionalPersonId;
        private string additionalPersonName;
        private string additionalPersonSurname;
        private string additionalPersonTel;
        private int done;
        private List<comment> comments;
        private List<reminder> reminders;
        private int followup;
        int followUpParentId;

        public appointment() { }

        public appointment(string appointmentDesc, DateTime appointmentDate, int appointmentTypeId, string personId, string personName, string personSurname, string tel, DateTime dateCreated, string intermediary, string additionalPersId, string additionalPersName, string additionalPersSurname, string additionalPersTel, int done, int followup, int followUpParentId)
        {
            this.AppointmentDesc = appointmentDesc;
            this.AppointmentDate = appointmentDate;
            this.AppointmentTypeId = appointmentTypeId;
            this.PersonId = personId;
            this.PersonName = personName;
            this.PersonSurname = personSurname;
            this.Tel = tel;
            this.DateCreated = dateCreated;
            this.Intermediary = intermediary;
            this.AdditionalPersonId = additionalPersId;
            this.AdditionalPersonName = additionalPersName;
            this.AdditionalPersonSurname = additionalPersSurname;
            this.AdditionalPersonTel = additionalPersTel;
            this.Done = done;
            this.Reminders = reminders;
            this.Followup = followup;
            this.FollowUpParentId = followUpParentId;
        }

        public appointment(int appointmentId, string appointmentDesc, DateTime appointmentDate, int appointmentTypeId, string personId, string personName, string personSurname, string tel, DateTime dateCreated, string intermediary, string additionalPersId, string additionalPersName, string additionalPersSurname, string additionalPersTel, int done, List<comment> comments, List<reminder> reminders, int followup, int followUpParentId)
        {
            this.AppointmentId = appointmentId;
            this.AppointmentDesc = appointmentDesc;
            this.AppointmentDate = appointmentDate;
            this.AppointmentTypeId = appointmentTypeId;
            this.PersonId = personId;
            this.PersonName = personName;
            this.PersonSurname = personSurname;
            this.Tel = tel;
            this.DateCreated = dateCreated;
            this.Intermediary = intermediary;
            this.AdditionalPersonId = additionalPersId;
            this.AdditionalPersonName = additionalPersName;
            this.AdditionalPersonSurname = additionalPersSurname;
            this.AdditionalPersonTel = additionalPersTel;
            this.Done = done;
            this.Comments = comments;
            this.Reminders = reminders;
            this.Followup = followup;
            this.FollowUpParentId = followUpParentId;
        }

        public appointment(int appointmentId, string appointmentDesc, DateTime appointmentDate, int appointmentTypeId, string personId, string personName, string personSurname, string tel, DateTime dateCreated, string intermediary, string additionalPersId, string additionalPersName, string additionalPersSurname, string additionalPersTel, int done, int followup, int followUpParentId)
        {
            this.AppointmentId = appointmentId;
            this.AppointmentDesc = appointmentDesc;
            this.AppointmentDate = appointmentDate;
            this.AppointmentTypeId = appointmentTypeId;
            this.PersonId = personId;
            this.PersonName = personName;
            this.PersonSurname = personSurname;
            this.Tel = tel;
            this.DateCreated = dateCreated;
            this.Intermediary = intermediary;
            this.AdditionalPersonId = additionalPersId;
            this.AdditionalPersonName = additionalPersName;
            this.AdditionalPersonSurname = additionalPersSurname;
            this.AdditionalPersonTel = additionalPersTel;
            this.Done = done;
            this.Followup = followup;
            this.FollowUpParentId = followUpParentId;
        }

        public string AppointmentDesc { get => appointmentDesc; set => appointmentDesc = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public int AppointmentTypeId { get => appointmentTypeId; set => appointmentTypeId = value; }
        public string PersonId { get => personId; set => personId = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string PersonSurname { get => personSurname; set => personSurname = value; }
        public string Tel { get => tel; set => tel = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public string Intermediary { get => intermediary; set => intermediary = value; }
        public string AdditionalPersonId { get => additionalPersonId; set => additionalPersonId = value; }
        public string AdditionalPersonName { get => additionalPersonName; set => additionalPersonName = value; }
        public string AdditionalPersonSurname { get => additionalPersonSurname; set => additionalPersonSurname = value; }
        public int Done { get => done; set => done = value; }
        public string AdditionalPersonTel { get => additionalPersonTel; set => additionalPersonTel = value; }
        public List<comment> Comments { get => comments; set => comments = value; }
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public List<reminder> Reminders { get => reminders; set => reminders = value; }
        public int Followup { get => followup; set => followup = value; }
        public int FollowUpParentId { get => followUpParentId; set => followUpParentId = value; }
    }
}
