using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Tools
{
    public class todayAppointments
    {
        Appointments appForm;

        public todayAppointments(Appointments a)
        {
            this.appForm = a;
        }

        public void populateTodayAppointments(DataTable todayAppointments)
        {
            appForm.todayData.DataSource = todayAppointments;
            appForm.todayData.Columns[0].Width = 300;
            appForm.todayData.Columns[1].Width = 150;
            appForm.todayData.Columns[2].Width = 150;
            appForm.todayData.Columns[3].Width = 150;
            appForm.todayData.Columns[4].Width = 150;
            appForm.todayData.Columns[5].Width = 350;
        }
    }
}
