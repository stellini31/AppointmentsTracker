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
    public static class Export
    {
        public static void exportAppointments(List<appointment> appointmentsToSave, Dictionary<int, string> appTypes, string fileName, ProgressBar pb)
        {
            SaveFileDialog savetoCSV = new SaveFileDialog();
            savetoCSV.Title = "Save Appointments as CSV";
            savetoCSV.FileName = fileName + "_" + DateTime.Now.ToShortDateString().Replace("/", "_");
            savetoCSV.Filter = "CSV File|*.csv";
            string initPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            savetoCSV.InitialDirectory = initPath;
            savetoCSV.RestoreDirectory = true;

            if(savetoCSV.ShowDialog() == DialogResult.OK)
            {
                pb.Visible = true;
                pb.Minimum = 1;
                pb.Maximum = appointmentsToSave.Count();

                using (Stream s = File.Open(savetoCSV.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine("Title, Schedule, Appointment Type, Person ID, Person Name, Person Surname, Tel Number, Date Created, Intermediary, Additional Person Id, Additional Person Name, Additional Person Surname, Additional Person Tel, Done, Follow Up");
                    foreach (appointment a in appointmentsToSave)
                    {
                        string appDesc = a.AppointmentDesc;
                        string appDate = a.AppointmentDate.ToString();
                        string appType = appTypes[a.AppointmentTypeId];
                        string pers1Id = a.PersonId;
                        string pers1Name = a.PersonName;
                        string pers1Surname = a.PersonSurname;
                        string tel = a.Tel;
                        string appCreated = a.DateCreated.ToString();
                        string intermediary = a.Intermediary;
                        string pers2Id = a.AdditionalPersonId;
                        string pers2Name = a.AdditionalPersonName;
                        string pers2Ssurname = a.AdditionalPersonSurname;
                        string pers2Tel = a.AdditionalPersonTel;
                        string done = a.Done.ToString();
                        string followUp = a.Followup.ToString();

                        string newLline = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}", appDesc, appDate, appType, pers1Id, pers1Name, pers1Surname, tel, appCreated, intermediary, pers2Id, pers2Name, pers2Ssurname, pers2Tel, done, followUp);
                        sw.WriteLine(newLline);

                        pb.PerformStep();
                    }
                }
            }
            
        }
    }
}
