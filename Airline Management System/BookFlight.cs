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
    public partial class BookFlight : Form
    {
        public static BookFlight instance;
       public TextBox t1, t2, t3, t4,  t8;
       public NumericUpDown t7;
      public  DateTimePicker t5, t6;
         

        string gender;

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFlight sf = new SearchFlight();
            sf.Show();
            this.Hide();

        }

        public BookFlight()
        {
            InitializeComponent();
            instance = this;
            t2 = airline_name;
            t3 = origin;
            t4 = destination;
            t5 = dateTimePicker1;
            t6 = dateTimePicker2;
            t7 = no_of_stop;
            t8 = fare;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                booking b = new booking();

                if (int.Parse(p_age.Text) < 8)
                {

                    int value = int.Parse(fare.Text);
                    double pay1 = Convert.ToDouble(value * 0.5);
                    fare.Text = pay1.ToString();

                    bool insert = b.Insert_In_BookFlight(airline_name.Text, origin.Text, destination.Text, dateTimePicker1.Text, dateTimePicker2.Text, no_of_stop.Value.ToString(), fare.Text, passenger_name.Text, p_age.Text, gender, dateTimePicker4.Text, phone.Text, cnic.Text, classs.Text, User_id.Text);
                    if (insert == true)
                    {
                        MessageBox.Show("Your Flight is booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Payment py = new Payment();
                        py.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                {

                    bool insert = b.Insert_In_BookFlight(airline_name.Text, origin.Text, destination.Text, dateTimePicker1.Text, dateTimePicker2.Text, no_of_stop.Value.ToString(), fare.Text, passenger_name.Text, p_age.Text, gender, dateTimePicker4.Text, phone.Text, cnic.Text, classs.Text, User_id.Text);
                    if (insert == true)
                    {
                        MessageBox.Show("Your Flight is booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Payment py = new Payment();
                        py.Show();
                        this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            
            User_id.ReadOnly = true;
           User_id.Text = LOGIN.instance.id.Text;







        }
    }
}
