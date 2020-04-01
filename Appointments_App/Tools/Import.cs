using Appointments_App.Classes;
using Appointments_App.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments_App.Tools
{
    public static class Import
    {
        public static void importAppointments(database dbConn)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(open.FileName);

                bool firstRow = true;

                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    if (firstRow != true)
                    {
                        string[] rows = line.Split(',');
                        string title = rows[0];
                        DateTime schedule = Convert.ToDateTime(rows[1]);
                        int appointmentTypeId = 3;
                        string personId = rows[3];
                        string personName = rows[4];
                        string personSurname = rows[5];
                        string personTel = rows[6];
                        DateTime created = Convert.ToDateTime(rows[7]);
                        string intermediary = rows[8];
                        string additionalPersonId = rows[9];
                        string additionalPersonName = rows[10];
                        string additionalPersonSurname = rows[11];
                        string additionalPersonTel = rows[12];
                        int done = Int32.Parse(rows[13]);
                        int followUp = 0;

                        appointment a = new appointment(title, schedule, appointmentTypeId, personId, personName, personSurname, personTel, created, intermediary, additionalPersonId, additionalPersonName, additionalPersonSurname, additionalPersonTel, done, followUp, -1);
                        dbConn.SaveAppointment(a);
                    }

                    firstRow = false;
                }
            }
        }
    }
}
