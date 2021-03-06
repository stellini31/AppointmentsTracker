﻿using Appointments_App.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Database
{
    public class database
    {
        string connString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

        /*public List<appointment> getAllAppointments(string addQuery = null)
        {
            string query = "SELECT * FROM Appointments ";

            if (addQuery != null)
            {
                query += addQuery;
            }
             
            List<appointment> appointments = new List<appointment>();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int appId = Int32.Parse(reader[0].ToString());
                    string desc = reader[1].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(reader[2].ToString());
                    int typeId = Int32.Parse(reader[4].ToString());
                    string persId = reader[3].ToString();
                    string persName = reader[5].ToString();
                    string persSurname = reader[6].ToString();
                    string tel = reader[7].ToString();
                    DateTime created = Convert.ToDateTime(reader[8]);
                    string intermediary = reader[9].ToString();
                    string additionalPersId = reader[10].ToString();
                    string additionalPersName = reader[11].ToString();
                    string additonalPersSurname = reader[12].ToString();
                    string additionalPersTel = reader[13].ToString();
                    int done = Int32.Parse(reader[14].ToString());
                    List<comment> comments = this.getAppointmentCommentsById(appId);
                    List<reminder> reminders = this.getRemindersByAppointmentId(appId);
                    int followup = Int32.Parse(reader[15].ToString());
                    int followUpParentId = Int32.Parse(reader[16].ToString());

                    appointment a = new appointment(appId, desc, appointmentDate, typeId, persId, persName, persSurname, tel, created, intermediary, additionalPersId, additionalPersName, additonalPersSurname, additionalPersTel, done, comments, reminders, followup, followUpParentId);
                    appointments.Add(a);
                }
                connection.Close();
                reader.Close();
            }
            return appointments;
        }*/

        public appointment getAppointmentByTitle(string title)
        {
            appointment a = new appointment();
            string query = "SELECT TOP 1 * FROM Appointments WHERE appointment_description = '"+ title + "';";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int appId = Int32.Parse(reader[0].ToString());
                    string desc = reader[1].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(reader[2].ToString());
                    int typeId = Int32.Parse(reader[4].ToString());
                    string persId = reader[3].ToString();
                    string persName = reader[5].ToString();
                    string persSurname = reader[6].ToString();
                    string tel = reader[7].ToString();
                    DateTime created = Convert.ToDateTime(reader[8]);
                    string intermediary = reader[9].ToString();
                    string additionalPersId = reader[10].ToString();
                    string additionalPersName = reader[11].ToString();
                    string additonalPersSurname = reader[12].ToString();
                    string additionalPersTel = reader[13].ToString();
                    int done = Int32.Parse(reader[14].ToString());
                    List<comment> comments = this.getAppointmentCommentsById(appId);
                    List<reminder> reminders = this.getRemindersByAppointmentId(appId);
                    int followup = Int32.Parse(reader[15].ToString());
                    int followUpParentId = Int32.Parse(reader[16].ToString());

                    a = new appointment(appId, desc, appointmentDate, typeId, persId, persName, persSurname, tel, created, intermediary, additionalPersId, additionalPersName, additonalPersSurname, additionalPersTel, done, comments, reminders, followup, followUpParentId);
                    return a;
                }
                connection.Close();
                reader.Close();
            }
            return a;
        }

        public DataTable getAllAppointmentsAsDataTable(string additionalQuery = null)
        {
            string selectCount = "SELECT TOP 200";
            string query =      " appointment_description AS Title, person_name AS Name, person_surname AS Surname, Format(appointment_date, \"Short Date\") as Schedule , appointment_type as Type, Comment, done " + @"                       
                                FROM(appointments
                                INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                                LEFT OUTER JOIN(select appointment_id, comment from comments where ID in (select MAX(ID) from comments group by appointment_id)) AS ta ON ta.appointment_id = appointments.id  ";

            if (additionalQuery != null)
            {
                query += additionalQuery;
                selectCount = "SELECT ";
            }
            query = selectCount + query + " ORDER BY appointment_date DESC";
            DataTable appointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                appointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return appointments;
        }

        public DataTable getAllAppointmentsAllData(string additionalQuery = null)
        {
            string query =      @"SELECT *                        
                                FROM(appointments
                                INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                                LEFT OUTER JOIN(select appointment_id, comment from comments where ID in (select MAX(ID) from comments group by appointment_id)) AS ta ON ta.appointment_id = appointments.id ";

            if (additionalQuery != null)
            {
                query += additionalQuery;
            }
            DataTable appointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                appointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return appointments;
        }

        public appointment getAppointmentById(int appointmentId)
        {
            appointment a;
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM Appointments where ID = " + appointmentId + ";", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int appId = Int32.Parse(reader[0].ToString());
                    string desc = reader[1].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(reader[2].ToString());
                    int typeId = Int32.Parse(reader[4].ToString());
                    string persId = reader[3].ToString();
                    string persName = reader[5].ToString();
                    string persSurname = reader[6].ToString();
                    string tel = reader[7].ToString();
                    DateTime created = Convert.ToDateTime(reader[8]);
                    string intermediary = reader[9].ToString();
                    string additionalPersId = reader[10].ToString();
                    string additionalPersName = reader[11].ToString();
                    string additonalPersSurname = reader[12].ToString();
                    string additionalPersTel = reader[13].ToString();
                    int done = Int32.Parse(reader[14].ToString());
                    List<comment> comments = this.getAppointmentCommentsById(appId);
                    List<reminder> reminders = this.getRemindersByAppointmentId(appId);
                    int followup = Int32.Parse(reader[15].ToString());
                    int followUpParentId = Int32.Parse(reader[16].ToString());

                    a = new appointment(appId, desc, appointmentDate, typeId, persId, persName, persSurname, tel, created, intermediary, additionalPersId, additionalPersName, additonalPersSurname, additionalPersTel, done, comments, reminders, followup, followUpParentId);
                    return a;
                }
                connection.Close();
                reader.Close();
            }
            return null;
        }

        public List<comment> getAppointmentCommentsById(int appointmentId)
        {
            string query = "SELECT comment, comment_type_id, date_added FROM Comments WHERE appointment_id = " + appointmentId + " ORDER BY date_added ASC;";
            List <comment> comments = new List<comment>();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string commentText = reader[0].ToString();
                    int commentTypeId = Int32.Parse(reader[1].ToString());
                    DateTime commentAdded = Convert.ToDateTime(reader[2].ToString());

                    comment c = new comment(commentText, commentTypeId, commentAdded);
                    comments.Add(c);
                }
            }
            return comments;
        }

        public List<appointment> getTodayAppointments()
        {
            List<appointment> appointments = new List<appointment>();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM Appointments WHERE appointment_date > DATE() AND appointment_date < DATE() +1 ORDER BY appointment_date;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int appId = Int32.Parse(reader[0].ToString());
                    string desc = reader[1].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(reader[2].ToString());
                    int typeId = Int32.Parse(reader[4].ToString());
                    string persId = reader[3].ToString();
                    string persName = reader[5].ToString();
                    string persSurname = reader[6].ToString();
                    string tel = reader[7].ToString();
                    DateTime created = Convert.ToDateTime(reader[8]);
                    string intermediary = reader[9].ToString();
                    string additionalPersId = reader[10].ToString();
                    string additionalPersName = reader[11].ToString();
                    string additonalPersSurname = reader[12].ToString();
                    string additionalPersTel = reader[13].ToString();
                    int done = Int32.Parse(reader[14].ToString());
                    List<comment> comments = this.getAppointmentCommentsById(appId);
                    List<reminder> reminders = this.getRemindersByAppointmentId(appId);
                    int followup = Int32.Parse(reader[15].ToString());
                    int followUpParentId = Int32.Parse(reader[16].ToString());

                    appointment a = new appointment(appId, desc, appointmentDate, typeId, persId, persName, persSurname, tel, created, intermediary, additionalPersId, additionalPersName, additonalPersSurname, additionalPersTel, done, comments, reminders, followup, followUpParentId);
                    appointments.Add(a);
                }
                connection.Close();
                reader.Close();
            }
            return appointments;
        }

        public DataTable getTodayAppointmentsDataTable()
        {
            string query = "SELECT appointment_description AS Title, person_name AS Name, person_surname AS Surname, Format(appointment_date, \"Short Time\") as Schedule , appointment_type as Type, Comment, done " + @"                       
                            FROM(appointments
                            INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                            LEFT OUTER JOIN(select appointment_id, comment from comments where ID in (select MAX(ID) from comments group by appointment_id)) AS ta ON ta.appointment_id = appointments.id
                            WHERE appointment_date > DATE() AND appointment_date < DATE() +1 AND done = 0
                            ORDER BY appointment_date;";
        

            DataTable appointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                appointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return appointments;
        }

        public DataTable getTodayAppointmentsAllData()
        {
            string query = @"SELECT *
                            FROM(appointments
                            INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                            INNER JOIN
                            (SELECT comment, appointments.ID from appointments
                            LEFT OUTER JOIN (SELECT TOP 1 * FROM comments ORDER BY date_added DESC) AS t ON t.appointment_id = appointments.id) AS ta ON ta.ID = appointments.id
                            WHERE appointment_date > DATE() AND appointment_date < DATE() +1 AND done = 0
                            ORDER BY appointment_date;";


            DataTable appointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                appointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return appointments;
        }

        public Dictionary<int, string> getVisibleAppointmentTypes()
        {
            string query = "SELECT  ID, appointment_type FROM AppointmentTypes WHERE visible = 1;";

            Dictionary<int, string> types = new Dictionary<int, string>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Int32.Parse(reader[0].ToString());
                    string type = reader[1].ToString();
                    types.Add(id,type);
                }
                connection.Close();
                reader.Close();
            }
            return types;
        }

        public Dictionary<int, string> getHiddenAppointmentTypes()
        {
            string query = "SELECT  ID, appointment_type FROM AppointmentTypes WHERE visible = 0;";

            Dictionary<int, string> types = new Dictionary<int, string>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Int32.Parse(reader[0].ToString());
                    string type = reader[1].ToString();
                    types.Add(id, type);
                }
                connection.Close();
                reader.Close();
            }
            return types;
        }

        public void updateAppointmentTypeToHidden(string type)
        {
            string query = "Update AppointmentTypes SET Visible = 0 where appointment_type in (" + type + ");";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void updateAppointmentTypeToVisible(string type)
        {
            string query = "Update AppointmentTypes SET Visible = 1 where appointment_type in (" + type + ");";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public bool existsType(string type)
        {
            string query = "SELECT  ID FROM AppointmentTypes WHERE appointment_type = '" + type + "';";
            bool exists = false;
            Dictionary<int, string> types = new Dictionary<int, string>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Int32.Parse(reader[0].ToString());
                    exists = true;
                }
                connection.Close();
                reader.Close();
            }
            return exists;
        }

        public void SaveAppointmentType(string text)
        {
            string query = "INSERT INTO AppointmentTypes (appointment_type, Visible) VALUES ('" + text + "', " + 1 + ");";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                connection.Close();
                reader.Close();
            }
        }

        /*public Dictionary<int, string> getAllAppointmentTypesDict()
        {
            string query = "SELECT * FROM AppointmentTypes;";

            Dictionary<int, string> types = new Dictionary<int, string>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Int32.Parse(reader[0].ToString());
                    string type = reader[1].ToString();
                    types.Add(id,type);
                }
                connection.Close();
                reader.Close();
            }
            return types;
        }*/

        public void SaveAppointment(appointment a)
        {
            string query = "INSERT INTO Appointments (appointment_description, appointment_date, appointment_type_id, person_id, person_name, person_surname, person_tel, appointment_created, intermediary_name, additional_person_id, additional_pers_name, additional_pers_surname, additional_pers_tel, done, followup, parentAppointment_id) VALUES ('" + a.AppointmentDesc + "', '" + a.AppointmentDate + "', '" + a.AppointmentTypeId + "', '" + a.PersonId + "', '" + a.PersonName + "', '" + a.PersonSurname + "', '" + a.Tel + "', '" + a.DateCreated + "', '" + a.Intermediary + "', '" + a.AdditionalPersonId + "', '" + a.AdditionalPersonName + "', '" + a.AdditionalPersonSurname + "', '" + a.AdditionalPersonTel + "', " + a.Done + ", " + a.Followup + ", " + a.FollowUpParentId + ");";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                connection.Close();
                reader.Close();
            }
        }

        public void saveComment(string comment, int comment_type_id, int appointmentId = -1)
        {
            int appointment_id = appointmentId != -1 ? appointmentId : this.getLastAppointmentId();
            DateTime dateAdded = DateTime.Now;

            string query = "INSERT INTO Comments (appointment_id, comment, comment_type_id, date_added) VALUES (" + appointment_id + ", '" + comment + "', " + comment_type_id + ", '" + dateAdded + "');";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                connection.Close();
                reader.Close();
            }
        }

        public int getLastAppointmentId()
        {
            int id = -1;
            string query = "SELECT TOP 1 ID FROM Appointments ORDER BY appointment_created DESC;";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                    return id;
                }
                connection.Close();
                reader.Close();
                return id;
            }
        }

        public int getAppointmentTypeId(string desc)
        {
            int id = -1;
            string query = "SELECT ID FROM AppointmentTypes where appointment_type = '" + desc + "';";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                    return id;
                }
                connection.Close();
                reader.Close();
                return id;
            }
        }

        public string getAppointmentTypeDesc(int id)
        {
            string desc = "";
            string query = "SELECT appointment_type FROM AppointmentTypes where ID = " + id + ";";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    desc = reader[0].ToString();
                    return desc;
                }
                connection.Close();
                reader.Close();
                return desc;
            }
        }

        /*public string getCommentsByAppointmentIdAsString(int appointmentId)
        {
            string comment = "";

            string query = "SELECT comment FROM Comments where appointment_id = " + appointmentId + ";";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string com = reader[0].ToString();
                    comment += com + " ";
                }
                connection.Close();
                reader.Close();
                return comment;
            }
        }*/

        public void saveReminder(reminder rem)
        {
            string date = rem.ReminderDate.ToShortDateString();
            string query = "INSERT INTO Reminders (reminder_date, reminder_message, appointment_id) VALUES ('" + date + "' , '" + rem.ReminderMessage + "', " + rem.AppointmentId + ");";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                
                connection.Close();
                reader.Close();
            }
        }

        /*public int getLastReminderId()
        {
            string query = "SELECT TOP 1 * FROM Reminders Order By ID DESC;";
            int id = -1;
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader[0].ToString());
                }
                connection.Close();
                reader.Close();
                return id;
            }
        }*/
        
        private List<reminder> getRemindersByAppointmentId(int appointmentId)
        {
            string query = "SELECT * FROM Reminders WHERE appointment_id = " + appointmentId + ";";
            List<reminder> reminders = new List<reminder>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int reminderId = Int32.Parse(reader[0].ToString());
                    DateTime reminderDate = Convert.ToDateTime(reader[1].ToString());
                    string reminderMessage = reader[2].ToString();
                    int dismissed = Int32.Parse(reader[4].ToString());

                    reminder rem = new reminder(reminderId, reminderDate, reminderMessage, appointmentId, dismissed);
                    reminders.Add(rem);
                }
                connection.Close();
                reader.Close();
                return reminders;
            }
        }

        public List<reminder> getTodayReminders()
        {
            string query = "SELECT * from Reminders WHERE reminder_date = Date() and dismissed = 0;";
            List<reminder> reminders = new List<reminder>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int reminderId = Int32.Parse(reader[0].ToString());
                    DateTime reminderDate = Convert.ToDateTime(reader[1].ToString());
                    string reminderMessage = reader[2].ToString();
                    int appointmentId = Int32.Parse(reader[3].ToString());
                    int dismissed = Int32.Parse(reader[4].ToString());

                    reminder rem = new reminder(reminderId, reminderDate, reminderMessage, appointmentId, dismissed);
                    reminders.Add(rem);
                }
                connection.Close();
                reader.Close();
                return reminders;
            }
        }

        public void dismissReminder(int reminderId)
        {
            string query = "Update Reminders SET dismissed = 1 where ID = " + reminderId + ";";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        public void dismissAllTodayReminders()
        {
            string query = "Update Reminders SET dismissed = 1 where reminder_date = Date();";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int getCountAllAppointments()
        {
            string query = "SELECT COUNT(*) FROM Appointments;";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int count  = Int32.Parse(reader[0].ToString());
                    return count;
                }
                connection.Close();
                reader.Close();
            }
            return -1;
        }

        public void closeAppointment(int appointmentId)
        {
            string query = "UPDATE Appointments SET done = 1 WHERE ID = " + appointmentId + ";";

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<appointment> getFollowUpsForAppointment(int appointmentId)
        {
            List<appointment> followups = new List<appointment>();
            string query = "SELECT  * FROM Appointments WHERE followup = 1 AND parentAppointment_id = " + appointmentId + " ORDER BY appointment_created DESC;";
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int appId = Int32.Parse(reader[0].ToString());
                    string desc = reader[1].ToString();
                    DateTime appointmentDate = Convert.ToDateTime(reader[2].ToString());
                    int typeId = Int32.Parse(reader[4].ToString());
                    string persId = reader[3].ToString();
                    string persName = reader[5].ToString();
                    string persSurname = reader[6].ToString();
                    string tel = reader[7].ToString();
                    DateTime created = Convert.ToDateTime(reader[8]);
                    string intermediary = reader[9].ToString();
                    string additionalPersId = reader[10].ToString();
                    string additionalPersName = reader[11].ToString();
                    string additonalPersSurname = reader[12].ToString();
                    string additionalPersTel = reader[13].ToString();
                    int done = Int32.Parse(reader[14].ToString());
                    List<comment> comments = this.getAppointmentCommentsById(appId);
                    List<reminder> reminders = this.getRemindersByAppointmentId(appId);
                    int followup = Int32.Parse(reader[15].ToString());
                    int followUpParentId = Int32.Parse(reader[16].ToString());

                    appointment a = new appointment(appId, desc, appointmentDate, typeId, persId, persName, persSurname, tel, created, intermediary, additionalPersId, additionalPersName, additonalPersSurname, additionalPersTel, done, comments, reminders, followup, followUpParentId);
                    followups.Add(a);
                }
                connection.Close();
                reader.Close();
            }
            return followups;
        }

        public int getAppointmentStatusById(int appointmentId)
        {
            string query = "SELECT done from appointments where ID = " + appointmentId + ";";
            int done = 0;

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    done = Int32.Parse(reader[0].ToString());
                    return done;
                }
                connection.Close();
                reader.Close();
            }
            return done;
        }

        public int getAppointmentStatusByTitle(string appointmentTitle)
        {
            string query = "SELECT done from appointments where appointment_description = '" + appointmentTitle + "';";
            int done = 0;

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    done = Int32.Parse(reader[0].ToString());
                    return done;
                }
                connection.Close();
                reader.Close();
            }
            return done;
        }

        public void UpdateAppointment(appointment a)
        {
            string query = "UPDATE Appointments SET appointment_description = '" + a.AppointmentDesc + "', appointment_date = '" + a.AppointmentDate + "', appointment_type_id = '" + a.AppointmentTypeId + "', person_id = '" + a.PersonId + "', person_name = '" + a.PersonName + "', person_surname = '" + a.PersonSurname + "', person_tel = '" + a.Tel + "', appointment_created = '" + a.DateCreated + "', intermediary_name = '" + a.Intermediary + "', additional_person_id = '" + a.AdditionalPersonId + "', additional_pers_name = '" + a.AdditionalPersonName + "', additional_pers_surname = '" + a.AdditionalPersonSurname + "', additional_pers_tel = '" + a.AdditionalPersonTel + "', done = " + a.Done + ", followup = " + a.Followup + ", parentAppointment_id = " + a.FollowUpParentId + " WHERE ID = " + a.AppointmentId + ";";  

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable searchTodayAppointmets(string text)
        {
            string query = "SELECT appointment_description AS Title, person_name AS Name, person_surname AS Surname, Format(appointment_date, \"Short Time\") as Schedule , appointment_type as Type, Comment, done " + @"                       
                            FROM(appointments
                            INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                            LEFT OUTER JOIN(select appointment_id, comment from comments where ID in (select MAX(ID) from comments group by appointment_id)) AS ta ON ta.appointment_id = appointments.id
                            WHERE appointment_date > DATE() AND appointment_date < DATE() +1 AND done = 0 AND
                            (Appointments.ID like ? OR appointment_description like ? OR person_id like ? or person_name like ? or person_surname like ? or person_tel like ? or additional_person_id like ? or additional_pers_name like ? or additional_pers_surname like ? or additional_pers_tel like ? or intermediary_name like ? )
                            ORDER BY appointment_date;";

            DataTable searchedTodayAppointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                searchedTodayAppointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return searchedTodayAppointments;
        }

        public DataTable searchAllAppointmets(string text)
        {
            string query = "SELECT appointment_description AS Title, person_name AS Name, person_surname AS Surname, Format(appointment_date, \"Short Date\") as Schedule , appointment_type as Type, Comment, done " + @"                       
                            FROM(appointments
                            INNER JOIN appointmentTypes ON appointmentTypes.ID = appointments.appointment_type_id)
                            LEFT OUTER JOIN(select appointment_id, comment from comments where ID in (select MAX(ID) from comments group by appointment_id)) AS ta ON ta.appointment_id = appointments.id
                            WHERE Appointments.ID like ? OR appointment_description like ? OR person_id like ? or person_name like ? or person_surname like ? or person_tel like ? or additional_person_id like ? or additional_pers_name like ? or additional_pers_surname like ? or additional_pers_tel like ? or intermediary_name like ?
                            ORDER BY appointment_date DESC;";

            DataTable searchedTodayAppointments = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                cmd.Parameters.AddWithValue("?", "%" + text + "%");
                searchedTodayAppointments.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return searchedTodayAppointments;
        }

        public List<reminder> getRemindersForAppointment(int appointmentId)
        {
            string query = "SELECT * FROM Reminders where appointment_id = " + appointmentId + " AND dismissed = 0 ORDER BY reminder_date ASC;";
            List<reminder> reminders = new List<reminder>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime remDate = Convert.ToDateTime(reader[1].ToString());
                    string message = reader[2].ToString();
                    int dissmised = Int32.Parse(reader[4].ToString());
                    reminder rem = new reminder(remDate, message, appointmentId, dissmised);
                    reminders.Add(rem);
                }
                connection.Close();
                reader.Close();
            }
            return reminders;
        }

        public bool appointmentTitleExists(string title)
        {
            string query = "SELECT ID FROM Appointments where appointment_description = '" + title + "';";
            List<int> ids = new List<int>();

            using (OleDbConnection connection = new OleDbConnection(this.connString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Int32.Parse(reader[0].ToString());
                    ids.Add(id);
                }
                connection.Close();
                reader.Close();
            }
            return ids.Count > 0 ? true : false;
        }
    }
}
