using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Server : Form
    {

        public string ip, db, user, pass;
        public Server()
        {
            InitializeComponent();
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



            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", textBox1.Text, txtDB.Text, txtUser.Text, txtpass.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeded", "Message    ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
