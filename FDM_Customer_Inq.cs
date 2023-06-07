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
    public partial class FDM_Customer_Inq : Form
    {
        public FDM_Customer_Inq()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Inqueries ci = new Customer_Inqueries();
            dataGridView1.DataSource= ci.Fetch_CustomerInqueries();
           
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDMpanel fp = new FDMpanel();
            fp.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
