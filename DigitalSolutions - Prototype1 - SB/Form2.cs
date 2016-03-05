using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSolutions___Prototype1___SB
{
    public partial class mainScreenFormAdmin : Form
    {
        public mainScreenFormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create Project Screen Form. Assign InstanceRef property "this" value which saves the state of "this" (Main Screen),
            //so when we click the "Back" button on the Project Screen we will come back to the same screen.
            //Part 1 of code adapted from: http://www.techrepublic.com/article/opening-form-instances-in-c/
            this.Hide();
            projectScreenForm projectScreen = new projectScreenForm();
            projectScreen.InstanceRef = this;
            projectScreen.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Secondary prompt to confirm logout
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //If the answer is yes, display message and close application.
                MessageBox.Show("Logout Successful");
                Application.Exit();
            }
        }

        private void enterHoursButton_Click(object sender, EventArgs e)
        {
            //Create Enter Hours Form. Assign InstanceRef property "this" value which saves the state of "this" (Main Screen),
            //so when we click the "Back" button on the Enter Hours screen we will come back to the same screen.
            enterHoursForm enterHours = new enterHoursForm();
            enterHours.InstanceRef = this;
            enterHours.Show();
        }

       
        private void employeeListingButton_Click(object sender, EventArgs e)
        {
            //Create Employee Listing Form. Assign InstanceRef property "this" value which saves the state of "this" (Main Screen),
            //so when we click the "Back" button on the Employee Listing screen we will come back to the same screen.
            employeeListingForm employeeListing = new employeeListingForm();
            employeeListing.InstanceRef = this;
            employeeListing.Show();
        }

        private void mainScreenFormAdmin_Load(object sender, EventArgs e)
        {
            const string PROJECT_INFO_QUARY = "SELECT sP.project_id, sP.project_name, sP.project_short_description, sP.project_start_date "
                                        + "FROM software_eng_db_1.project AS sP;" 
                                        + "SELECT cus.client_name FROM software_eng_db_1.customer AS cus";

            RetrieveData rData = new RetrieveData(PROJECT_INFO_QUARY);
            DataSet projectInfoDs = rData.retrieveData();

            //now convert DataSet to string datatype
            Converter conv = new Converter(projectInfoDs);
            string[,] strData = conv.convertDataSetToArray(0, 4);

            mainScreenListView.Items.Add(strData[0, 0], 0);
            mainScreenListView.Items.Add(strData[0, 1], 1);
            //MessageBox.Show();
        }
    }
}
