using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class booking
    {
        DAL OBJDAL = new DAL();


        public bool Insert_In_BookFlight(string airline_name, string origin, string Destination, string Departure, string arrival, string no_of_stop, string fare ,string passenger_name,string age,string gender,string dob, string phone , string nic , string classs,string id  )
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_Booking", airline_name, origin, Destination, Departure, arrival, no_of_stop, fare,passenger_name,age,gender,dob, phone,nic,classs,id);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public DataTable FETCH_BY_RESERVATION(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_RESERVATION", id);
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }

        public DataTable Fetch_Reservation_By_Condition(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_RESERVATION_BY_CONDITION", id);
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;

        }


        public DataTable Fetch_AllReservation()
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_ALL_RESERVATION");
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }


        public bool Delete_Reservation(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_DELETE_RESERVATION", id);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }


        public bool Update_Reservation(string id, string Passenger_name, string Age, string Gender, string DOB, string Phone, string Nic, string ClassS)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_UPDATE_RESERVATION", id, Passenger_name,Age,Gender,DOB,Phone,Nic,ClassS);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }



        ~booking()
        {

        }


        //public DataTable Fetch_Reservation()
        //{
        //    OBJDAL.OpenConnection();
        //    OBJDAL.LoadSpParameters("SP_FETCH_RESERVATION_FOR_FDM");
        //    DataTable dt = OBJDAL.GetDataTable();
        //    OBJDAL.ExecuteQuery();
        //    OBJDAL.UnLoadSpParameters();
        //    OBJDAL.CloseConnection();
        //    return dt;
        //}
    }
}
