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


            string connectionString = $"Data Source={ip};Initial Catalog={db};User ID={user};Password={pass}";
           // dataAccessLayer.SetConnectionString(connectionString);


        }
        public void OpenConnection()
        {

            dataAccessLayer.OpenConnection();


        }


    }
}
