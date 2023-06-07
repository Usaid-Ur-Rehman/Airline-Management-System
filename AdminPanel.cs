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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aircraft_update A = new Aircraft_update();
            A.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageUser m = new ManageUser();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Flight update_Flight = new Update_Flight();
            update_Flight.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SIGNUP sign = new SIGNUP();
            sign.Show();
            this.Hide();



        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }
    }
}
