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
    public partial class Aircraft : Form
    {
        public Aircraft()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                aircraft aircraft = new aircraft();
                bool insert = aircraft.Insert_In_Aircraft(Aircraft_name.Text, Aircraft_numeric.Value.ToString());
                if (insert == true)
                {

                    MessageBox.Show("New Aircraft added successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();


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
    }
}
