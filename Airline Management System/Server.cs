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
    public partial class Server : Form
    {
        private ServerLayer serverlayer;


        public string ip { get; set; }
        public string db { get; set; }
        public string user { get; set; }
        public string pass { get; set; }

        public Server()
        {
            InitializeComponent();
            serverlayer = new ServerLayer();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add("DESKTOP-TI373IO\\MSSQLSERVER01");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {






        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {

            ip = textBox1.Text;
            db = txtDB.Text;
            user = txtUser.Text;
            pass = txtpass.Text;

            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", textBox1.Text,txtDB.Text, txtUser.Text,txtpass.Text);
            serverlayer.SetConnectionString(ip,db,user,pass);
            try
            {
                serverlayer.OpenConnection(); // Open the connection using the DAL's OpenConnection method

                MessageBox.Show("Test connection succeeded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();



        }

    }
}
