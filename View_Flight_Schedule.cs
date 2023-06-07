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
    public partial class View_Flight_Schedule : Form
    {
        public View_Flight_Schedule()
        {
            InitializeComponent();
        }

        private void View_Flight_Schedule_Load(object sender, EventArgs e)
        {
            flightt flightt = new flightt();
            dataGridView1.DataSource = flightt.Fetch_In_flight();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inquiry_Form inq = new Inquiry_Form();
            inq.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIGNUP sign = new SIGNUP();
            sign.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
