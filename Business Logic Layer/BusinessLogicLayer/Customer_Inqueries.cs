using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Customer_Inqueries
    {
        DAL OBJDAL = new DAL();
       
        public DataTable Fetch_CustomerInqueries()
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_Customer_Inqueries");
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }


        public bool Insert_In_Queries(string Fullname,string email,string phone, string msg  )
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_Customer_inquiries", Fullname, email, phone, msg);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        ~Customer_Inqueries()
        {

        }

    }
}
