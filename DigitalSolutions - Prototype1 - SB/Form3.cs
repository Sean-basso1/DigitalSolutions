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
    public partial class enterHoursForm : Form
    {
        public enterHoursForm()
        {
            InitializeComponent();
        }

        //Used to save the "state" of the Main Screen so we can go back to same instance instead of creating new form.
        //Part 2 of code adapted from: http://www.techrepublic.com/article/opening-form-instances-in-c/
        private Form m_InstanceRef = null;
        public Form InstanceRef
        {
            get
            {
                return m_InstanceRef;
            }
            set
            {
                m_InstanceRef = value;
            }
        }

        private void submitHoursButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hours submitted successfully");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //InstanceRef contains the "state" of the Main Screen. So when we call ".Show" on it we are bringing back
            //the main screen form.
            this.Hide();
            InstanceRef.Show();
        }
    }
}
