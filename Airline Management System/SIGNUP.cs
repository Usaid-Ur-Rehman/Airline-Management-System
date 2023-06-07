using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Airline_Management_System
{
    public partial class SIGNUP : Form
    {
        public static SIGNUP instance;
        Server server;
        public SIGNUP()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ltype.Hide();
            typelabel.Hide();
            type.Hide();
            server = new Server();
            server.ShowDialog();
            string IP = server.ip;
            string DB = server.db;
            string USER = server.user;
            string PASS = server.pass;


            string sql = "select * from SIGNUP_UP where type = '" + LOGIN.instance.l1.Text + "'";





            SqlDataAdapter adapter = new SqlDataAdapter(sql, $"Data Source={IP};Initial Catalog={DB};User ID={USER};Password={PASS}");

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            foreach (DataRow dr in dataTable.Rows)
            {
                ltype.Text = dr["type"].ToString();
                if (dr["type"].ToString() == "admin")
                {

                    typelabel.Show();
                    type.Show();
                }
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyAccount obj = new MyAccount();
                bool insert = obj.InsertAccount(username.Text, email.Text, password.Text, phoneno.Text, address.Text);
                if (insert == true)
                {
                    MessageBox.Show("Your Account is created. Welcome to Airline Booking Management System!", "ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LOGIN lg = new LOGIN();
                    lg.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
           
        }
    }
}
