using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Airline_Management_System
{
    public partial class Inquiry_Form : Form
    {
        public Inquiry_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_Inqueries ci = new Customer_Inqueries();
                bool inserted = ci.Insert_In_Queries(Fullname.Text, Email.Text, phone.Text, message.Text);

                if (inserted == true)
                {
                    MessageBox.Show("Your query will be replied soon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
            
             catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inquiry_Form inq = new Inquiry_Form();
            inq.Show();
            this.Hide();
     
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void dededToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }
    }
}
