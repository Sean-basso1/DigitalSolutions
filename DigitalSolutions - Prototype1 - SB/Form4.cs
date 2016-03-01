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
    public partial class projectScreenForm : Form
    {
        public projectScreenForm()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstanceRef.Show();
        }

        
        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            //Create the Create Invoice Form. Assign InstanceRef property "this" value which saves the state of "this" (Project Screen),
            //so when we click the "Back" button on the Create Invoice screen we will come back to the same screen.
            createInvoiceForm createInvoice = new createInvoiceForm();
            createInvoice.InstanceRef = this;
            createInvoice.Show();
            
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes applied successfully.");
        }
    }
}
