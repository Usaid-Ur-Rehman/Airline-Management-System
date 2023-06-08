using System.Linq;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;



namespace BusinessLogicLayer
{
    public class ServerLayer
    {

        private DAL dataAccessLayer;

        public ServerLayer()
        {

            dataAccessLayer = new DAL();

        }

        public void SetConnectionString(string ip, string db,string user,string pass)
        {


            dataAccessLayer = new DAL();
            dataAccessLayer.SetConnectionString(ip,db,user,pass);


        }
        public void OpenConnection()
        {

            dataAccessLayer.OpenConnection();


        }


    }
}
