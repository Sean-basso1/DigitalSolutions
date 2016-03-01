using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DigitalSolutions___Prototype1___SB
{
    public partial class createInvoiceForm : Form
    {
        public createInvoiceForm()
        {
            InitializeComponent();
        }

        //Used to save the "state" of the Project Screen
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstanceRef.Show();
        }

        private void viewInvoiceButton_Click(object sender, EventArgs e)
        {
            //Starts the default PDF viewer on the host computer to view the .PDF stored at the specified filepath.
            Process.Start("H:\\CSIS 3275 - Software Engineering\\Digital Solutions Files\\Project Proposal\\Invoice.pdf");
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Command sent.");
        }
    }
}
