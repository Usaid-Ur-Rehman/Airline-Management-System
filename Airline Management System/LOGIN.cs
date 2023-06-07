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
using SecuirtyPurpose;

namespace Airline_Management_System
{






    public partial class LOGIN : Form
    {

        ServerLayer serverlayer;
        MyAccount myAccount;
        Server server;
        public static LOGIN instance;
        public Label l1, id;
        public LOGIN()
        {
            InitializeComponent();
            instance = this;
            l1 = ltype;
            id = u_id;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            myAccount = new MyAccount();
            serverlayer = new ServerLayer();
            server = new Server();
            server.ShowDialog();
            string IP = server.ip;
            string DB = server.db;
            string USER = server.user;
            string PASS = server.pass;

            string connectionString = $"Data Source={IP};Initial Catalog={DB};User ID={USER};Password={PASS}";
           

            //string Email, Pass_word;
            //Email = email.Text.Trim();
            // Pass_word = password.Text.Trim();

            EncapsulationLogin EC = new EncapsulationLogin();
            EC.EMAIL = email.Text.Trim();
            EC.PASSWORD = password.Text.Trim();





            string query = "EXEC SP_LOGIN'" + EC.EMAIL + "' , '" + EC.PASSWORD + "' ";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // dataTable= myAccount.LOGIN(Email, Pass_word);

                if (dataTable.Rows.Count > 0)
                {

                    foreach (DataRow dr in dataTable.Rows)
                    {
                        ltype.Text = dr["type"].ToString();
                        u_id.Text = dr["id"].ToString();
                        if (dr["type"].ToString() == "admin")
                        {
                            AdminPanel a = new AdminPanel();
                            a.Show();
                            this.Hide();
                        }
                        else if (dr["type"].ToString() == "frontdesk")
                        {
                            FDMpanel fDMpanel = new FDMpanel();
                            fDMpanel.Show();
                            this.Hide();

                        }
                        else
                        {
                            UserPanel u = new UserPanel();
                            u.Show();
                            this.Hide();


                        }
                    }



                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            ltype.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SIGNUP signup = new SIGNUP();
            signup.Show();
            this.Hide();




        }
    }
}
