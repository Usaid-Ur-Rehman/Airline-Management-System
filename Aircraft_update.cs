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
    public partial class Aircraft_update : Form
    {
        public Aircraft_update()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aircraft a= new Aircraft();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                aircraft aircraft = new aircraft();
                bool Delete = aircraft.Delete_In_Aircraft(Aircraft_id.Text);
                if (Delete == true)
                {
                    MessageBox.Show("Aircraft data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                aircraft aircraft = new aircraft();
                bool Update = aircraft.Update_In_Aircraft(Aircraft_id.Text, Aircraft_name.Text, Aircraft_Numeric.Value.ToString());
                if (Update == true)
                {
                    MessageBox.Show("Aircraft data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void Aircraft_update_Load(object sender, EventArgs e)
        {
            aircraft aircraft = new aircraft();
            dataGridView1.DataSource = aircraft.Fetch_In_aircraft();


        }

        private void Aircraft_view_Click(object sender, EventArgs e)
        {
            aircraft aircraft = new aircraft();
            dataGridView1.DataSource = aircraft.Fetch_In_aircraft();
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Aircraft_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Aircraft_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Aircraft_Numeric.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
