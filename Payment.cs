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
using SecuirtyPurpose;

namespace Airline_Management_System
{




    public partial class Payment : Form
    {
    
       
        

        public Payment()
        {
            InitializeComponent();
           
            
        }


        EncapsulationPayment ep = new EncapsulationPayment();
        
        private void button2_Click(object sender, EventArgs e)
        {


            ep.CO = card_owner.Text;
            ep.Card_NO = card_no.Text;
            ep.Cvv = cvv.Text;
            ep.cardtype = card_type.Text;
            ep.CM = ex_mon.Text;
            ep.expc = ex_yr.Text;

            try
            {
                PaymentDetails pd = new PaymentDetails();
                bool insert = pd.Insert_PaymentDetails(ep.CO, ep.Card_NO, ep.Cvv, ep.cardtype, ep.CM, ep.expc);
                if (insert == true)
                {
                    MessageBox.Show("Ticket Booked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void AmtLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LabelAmount.Text = BookFlight.instance.t8.Text;
        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
