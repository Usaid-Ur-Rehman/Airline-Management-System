using System.Linq;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogicLayer
{
    public class MyAccount
    { DAL OBJDAL = new DAL();
        public bool InsertAccount(string username, string email, string password, string phone, string address, string Type)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_SIGNUP", username, email, password, phone, address, Type);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;

        }
        public bool InsertAccount(string username, string email, string password, string phone, string address)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_INSERT_USIGNUP", username, email, password, phone, address);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }

        public DataTable Fetch_In_User()
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_USER");
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }

        public DataTable Fetch_User_By_Condition(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_FETCH_USER_BY_CONDITION",id);
            DataTable dt = OBJDAL.GetDataTable();
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return dt;
        }

        public bool Delete_User(string id)
        {
            OBJDAL.OpenConnection();
            OBJDAL.LoadSpParameters("SP_DELETE_USER", id);
            OBJDAL.ExecuteQuery();
            OBJDAL.UnLoadSpParameters();
            OBJDAL.CloseConnection();
            return true;
        }






        ~MyAccount()
        {

        }

    }

        
}
