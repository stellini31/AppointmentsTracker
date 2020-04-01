using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Tools
{
    public class allAppointments
    {
        Appointments appForm;

        public allAppointments(Appointments a)
        {
            this.appForm = a;
        }

        public void populateAllAppointments(DataTable allAppointments)
        {
            appForm.allAppoitnmentsData.DataSource = allAppointments;
            appForm.allAppoitnmentsData.Columns[0].Width = 300;
            appForm.allAppoitnmentsData.Columns[1].Width = 150;
            appForm.allAppoitnmentsData.Columns[2].Width = 150;
            appForm.allAppoitnmentsData.Columns[3].Width = 150;
            appForm.allAppoitnmentsData.Columns[4].Width = 150;
            appForm.allAppoitnmentsData.Columns[5].Width = 350;
        }
    }
}
