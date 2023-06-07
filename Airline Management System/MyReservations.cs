using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Airline_Management_System
{
    public partial class MyReservations : Form
    {
        string gender;
        public MyReservations()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking b = new booking();
            dataGridView1.DataSource = b.FETCH_BY_RESERVATION(LOGIN.instance.id.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                booking bk = new booking();


                bool Update = bk.Update_Reservation(id.Text, passenger_name.Text, p_age.Text, gender, dateTimePicker.Text, phone.Text, cnic.Text, classType.Text);
                if (Update == true)
                {
                    MessageBox.Show("Flight Reservation updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                booking bk = new booking();
                bool Delete = bk.Delete_Reservation(id.Text);
                if (Delete == true)
                {
                    MessageBox.Show("Flight Reservation deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);




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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            passenger_name.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            p_age.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            string gender = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            if (gender == "Male")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }

            dateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            cnic.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            classType.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();

        }

        private void MyReservations_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }
    }
}
