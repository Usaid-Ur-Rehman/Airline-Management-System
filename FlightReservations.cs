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
    public partial class FlightReservations : Form
    {
        string gender;
        public FlightReservations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FDMpanel fp = new FDMpanel();
            fp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                booking bk = new booking();
                dataGridView1.DataSource = bk.Fetch_Reservation_By_Condition(userid.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            booking bk = new booking();
            dataGridView1.DataSource = bk.Fetch_AllReservation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                booking bk = new booking();
                bool Delete = bk.Delete_Reservation(id.Text);
                if (Delete == true)
                {

                    refund r = new refund();
                    r.Insert_In_refund(passenger_name.Text, p_age.Text, gender, dateTimePicker.Text, phone.Text, cnic.Text, classType.Text);
                    MessageBox.Show("Flight Reservation deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    RefundPayment rp = new RefundPayment();
                    rp.Show();


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

        private void FlightReservations_Load(object sender, EventArgs e)
        {
            
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

        private void userid_TextChanged(object sender, EventArgs e)
        {

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
