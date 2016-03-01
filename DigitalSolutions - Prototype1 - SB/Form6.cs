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
    public partial class employeeListingForm : Form
    {
        public employeeListingForm()
        {
            InitializeComponent();
        }

        //Used to save the "state" of the Main Screen so we can go back to same instance instead of creating new form.
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstanceRef.Show();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes applied successfully.");
        }
    }
}
