using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Flight_Schedule v = new View_Flight_Schedule();
            v.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFlight sf = new SearchFlight();
            sf.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MyReservations MR = new MyReservations();
            MR.Show();
            this.Hide();
        }
    }
}
