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
    public partial class Update_Flight : Form
    {
        public Update_Flight()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Flight flight = new Flight();
            flight.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                flightt f = new flightt();
                bool Update = f.Update_In_flight(flight_id.Text, airline_name.Text, origin.Text, destination.Text, dateTimePicker1.Text, dateTimePicker2.Text, no_of_stop.Value.ToString(), fare.Text);
                if (Update == true)
                {
                    MessageBox.Show("Flight data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                flightt f = new flightt();
                bool Update = f.Delete_In_flight(flight_id.Text);
                if (Update == true)
                {
                    MessageBox.Show("Flight data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            flightt flightt = new flightt();
            dataGridView1.DataSource = flightt.Fetch_In_flight();
                
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             flight_id.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            airline_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            origin.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            destination.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            no_of_stop.Value= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            fare.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void Update_Flight_Load(object sender, EventArgs e)
        {

        }
    }
}
