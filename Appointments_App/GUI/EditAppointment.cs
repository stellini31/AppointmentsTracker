using Appointments_App.Classes;
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
    public partial class EditAppointment : Form
    {
        appointment a;

        public EditAppointment(appointment app)
        {
            InitializeComponent();
            this.a = app;
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            title_label.Text = a.AppointmentDesc;
            created_text.Text = a.DateCreated.ToString("dd/MM/yyyy");
        }
    }
}
