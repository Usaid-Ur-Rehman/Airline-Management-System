using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class flightt
    {

        DAL OBJDAL = new DAL();

       

        public bool Insert_In_Airline(string airline_name, string origin, string Destination,string Departure,string  arrival,string no_of_stop,string fare)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_FLIGHT", airline_name,origin,Destination,Departure,arrival,no_of_stop,fare);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public bool Update_In_flight(string id ,string airline_name, string origin, string Destination, string Departure, string arrival, string no_of_stop, string fare)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_UPDATE_FLIGHT", id,airline_name, origin, Destination, Departure, arrival, no_of_stop, fare);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public bool Delete_In_flight(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_DELETE_FLIGHT", id);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public DataTable Fetch_In_flight()
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_FLIGHT");
          DataTable dt=  OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }

        public DataTable Fetch_By_CONDITION(string origin,string destination,string airline_name)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_FLIGHT_BY_CONDITION", origin,destination,airline_name);
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }

        ~flightt()
        {

        }
    
    }
}
