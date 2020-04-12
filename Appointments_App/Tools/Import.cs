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
        
        public static void importAppointments(database dbConn, ProgressBar progressBar)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(open.FileName);

                  

                    setMinMaxPB(progressBar, 0, File.ReadLines(open.FileName).Count());

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
                            string comment = rows[15];

                            appointment a = new appointment(title, schedule, appointmentTypeId, personId, personName, personSurname, personTel, created, intermediary, additionalPersonId, additionalPersonName, additionalPersonSurname, additionalPersonTel, done, followUp, -1);
                            dbConn.SaveAppointment(a);
                            if (comment != "")
                            {
                                dbConn.saveComment(comment, 5, -1);
                            }
                        }
                        firstRow = false;

                        increment(progressBar);
                    }
                    hidePB(progressBar);
                }
                catch(IOException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        delegate void incrementCallBack(ProgressBar progressBar);
        delegate void setMinMaxPBCallBack(ProgressBar progressBar, int min, int max);
        delegate void hidePBCallBack(ProgressBar progressBar);

        private static void increment(ProgressBar progressBar)
        {
            if (progressBar.InvokeRequired)
            {
                incrementCallBack i = new incrementCallBack(increment);
                progressBar.Invoke(i, new object[] { progressBar });
            }
            else
            {
                progressBar.Increment(1);
            }
        }

        private static void setMinMaxPB(ProgressBar progressBar, int min, int max)
        {
            if (progressBar.InvokeRequired)
            {
                setMinMaxPBCallBack i = new setMinMaxPBCallBack(setMinMaxPB);
                progressBar.Invoke(i, new object[] { progressBar, min, max });
            }
            else
            {
                progressBar.Visible = true;
                progressBar.Minimum = min;
                progressBar.Maximum = max;
            }
        }

        private static void hidePB(ProgressBar progressBar)
        {
            if (progressBar.InvokeRequired)
            {
                hidePBCallBack i = new hidePBCallBack(hidePB);
                progressBar.Invoke(i, new object[] { progressBar});
            }
            else
            {
                progressBar.Visible = false;
            }
        }
    }
}
