using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PaymentDetails
    {
        DAL OBJDAL = new DAL();

        public bool Insert_PaymentDetails(string Card_Owner, string Card_Number, string CVV, string Card_Type, string Exp_Month, string Exp_Yr)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_PaymentDetails", Card_Owner, Card_Number, CVV, Card_Type, Exp_Month, Exp_Yr);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }



        ~PaymentDetails()
        {

        }
    }
}
