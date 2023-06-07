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
    public partial class SearchFlight : Form
    {
        public static SearchFlight instance;
        public DataGridView d1;
        public string airline_name, origin, destination, departure, arrival, no_of_stop, fare;

        private void SearchFlight_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            BookFlight b = new BookFlight();
            b.Show();

          
            BookFlight.instance.t2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            BookFlight.instance.t3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            BookFlight.instance.t4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            BookFlight.instance.t5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            BookFlight.instance.t6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            BookFlight.instance.t7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            BookFlight.instance.t8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.Hide();
        }

        public SearchFlight()
        {
            InitializeComponent();
            instance = this;
            d1 = dataGridView1;
        



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                flightt flightt = new flightt();
                dataGridView1.DataSource = flightt.Fetch_By_CONDITION(Origin.Text, Destination.Text, Airline.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookFlight bf= new BookFlight();
            bf.Show();
        } 
    }
}
