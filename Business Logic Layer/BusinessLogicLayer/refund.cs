using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class refund
    {


        DAL OBJDAL = new DAL();


        public bool Insert_In_refund( string passenger_name, string age, string gender, string dob, string phone, string nic, string classs)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_Refund",  passenger_name, age, gender, dob, phone, nic, classs);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }



        public DataTable FetchRf()
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_Refundd");
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }
        public DataTable FetchRf(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_Refund2",id);
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }


        ~refund()
        {

        }

    }
}
