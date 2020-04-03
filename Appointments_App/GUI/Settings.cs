using Appointments_App.Database;
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
    public partial class Settings : Form
    {
        database dbConn;

        public Settings()
        {
            InitializeComponent();
            this.dbConn = new database();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> appTyes = dbConn.getVisibleAppointmentTypes();
            Dictionary<int, string> hiddenAppTyes = dbConn.getHiddenAppointmentTypes();
            foreach (string type in appTyes.Values)
            {
                visibleAppTypes_list.Items.Add(type);
            }

            foreach (string type in hiddenAppTyes.Values)
            {
                notvisibleAppTypes_list.Items.Add(type);
            }
        }

        private void selectNotVisible_buton_Click(object sender, EventArgs e)
        {
            string type = visibleAppTypes_list.SelectedItem.ToString();
            visibleAppTypes_list.Items.RemoveAt(visibleAppTypes_list.SelectedIndex);
            visibleAppTypes_list.Refresh();
            dbConn.updateAppointmentTypeToHidden("'" + type + "'");

            if(visibleAppTypes_list.Items.Count < 2)
            {
                moveToHidden.Enabled = false;
            }

            notvisibleAppTypes_list.Items.Add(type);
        }

        private void moveToVisible_button_Click(object sender, EventArgs e)
        {
            if(notvisibleAppTypes_list.SelectedIndex >= 0)
            {
                string type = notvisibleAppTypes_list.SelectedItem.ToString();
                notvisibleAppTypes_list.Items.RemoveAt(notvisibleAppTypes_list.SelectedIndex);
                notvisibleAppTypes_list.Refresh();
                dbConn.updateAppointmentTypeToVisible("'" + type + "'");

                visibleAppTypes_list.Items.Add(type);
                moveToHidden.Enabled = true;
            }
            
        }

        private void moveAllToVisible_button_Click(object sender, EventArgs e)
        {
            string items = String.Empty;
            foreach (string item in notvisibleAppTypes_list.Items) {
                visibleAppTypes_list.Items.Add(item);
                items += "'" + item + "',";
            }
            if(items != string.Empty)
            {
                items = items.Substring(0, items.Length - 1);
                dbConn.updateAppointmentTypeToVisible(items);
            }
               
            notvisibleAppTypes_list.Items.Clear();
        }

        private void addType_button_Click(object sender, EventArgs e)
        {
            string type = appType_text.Text;
            if (type != "")
            {
                if (!dbConn.existsType(type))
                {
                    dbConn.SaveAppointmentType(type);
                    appType_text.Text = "";
                    visibleAppTypes_list.Items.Add(type);
                }
                else
                {
                    error_label.Text = "Appointment type already exists.";
                    error_label.Visible = true;
                }
            }
            else
            {
                error_label.Text = "Please enter a Value.";
                error_label.Visible = true;

                hideError_label.Interval = 3000;
                hideError_label.Tick += hideError_label_Tick;
                hideError_label.Start();
            }
                
        }

        private void hideError_label_Tick(object sender, EventArgs e)
        {
            error_label.Visible = false;
            hideError_label.Stop();

            hideError_label.Interval = 3000;
            hideError_label.Tick += hideError_label_Tick;
            hideError_label.Start();
        }
    }
}
