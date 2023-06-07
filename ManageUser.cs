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
    public partial class ManageUser : Form
    {
        public static ManageUser instance;
        public ManageUser()
        {
            InitializeComponent();
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyAccount m = new MyAccount();
            dataGridView1.DataSource = m.Fetch_In_User();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyAccount ma = new MyAccount();
                bool deleted = ma.Delete_User(userid.Text);
                if (deleted == true)
                {
                    MessageBox.Show("User Account deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MyAccount ma = new MyAccount();
                dataGridView1.DataSource = ma.Fetch_User_By_Condition(userid.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
