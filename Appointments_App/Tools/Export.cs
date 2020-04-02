using Appointments_App.Classes;
using Appointments_App.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointments_App.Tools
{
    public static class Export
    {
        public static void exportAppointments(DataTable appointments, string fileName)
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
                using (Stream s = File.Open(savetoCSV.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine("Title, Schedule, Appointment Type, Person ID, Person Name, Person Surname, Tel Number, Date Created, Intermediary, Additional Person Id, Additional Person Name, Additional Person Surname, Additional Person Tel, Done, Follow Up, Last Comment");
                    foreach (DataRow a in appointments.AsEnumerable())
                    {
                        string appDesc = a[1].ToString();
                        string appDate = a[2].ToString();
                        string appType = a[18].ToString();
                        string pers1Id = a[3].ToString();
                        string pers1Name = a[5].ToString();
                        string pers1Surname = a[6].ToString();
                        string tel = a[7].ToString(); ;
                        string appCreated = a[8].ToString();
                        string intermediary = a[9].ToString();
                        string pers2Id = a[10].ToString();
                        string pers2Name = a[11].ToString();
                        string pers2Ssurname = a[12].ToString();
                        string pers2Tel = a[13].ToString();
                        string done = a[14].ToString();
                        string followUp = a[15].ToString();
                        string lastComment = a[19].ToString();

                        string newLline = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", appDesc, appDate, appType, pers1Id, pers1Name, pers1Surname, tel, appCreated, intermediary, pers2Id, pers2Name, pers2Ssurname, pers2Tel, done, followUp, lastComment);
                        sw.WriteLine(newLline);
                    }
                }
            }
            
        }
    }
}
