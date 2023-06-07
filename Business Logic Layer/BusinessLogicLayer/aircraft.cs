using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class aircraft
    {
        DAL OBJDAL = new DAL();

       
        public bool Insert_In_Aircraft(string aircraft_name, string aircraft_numeric)
        {

            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_AIRCRAFT", aircraft_name, aircraft_numeric);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public bool Delete_In_Aircraft(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_DELETE_AIRCRAFT", id);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }


        public bool Update_In_Aircraft(string id, string aircraft_name, string aircraft_numeric)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_UPDATE_AIRCRAFT", id, aircraft_name,  aircraft_numeric);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }


    

            

            public DataTable Fetch_In_aircraft()
            {
                OBJDAL.OpenConnection();
                OBJDAL.LoadSpParameters("SP_FETCH_AIRCRAFT");
                DataTable dt = OBJDAL.GetDataTable();
                OBJDAL.ExecuteQuery();
                OBJDAL.UnLoadSpParameters();
                OBJDAL.CloseConnection();
                return dt;
            }





        ~aircraft()
        {

        }



    }
}
