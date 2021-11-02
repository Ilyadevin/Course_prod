using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Course_prod
{
    class DB
    {
        SqlConnection connetion = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;DataBase=Course_prod_bd;Trusted_Connection=True");
        public void openConnection()
        {
            if (connetion.State == System.Data.ConnectionState.Closed)
            {
                connetion.Open();
            }
        }
        public void closeConnection()
        {
            if (connetion.State == System.Data.ConnectionState.Open)
            {
                connetion.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return connetion;
        }
    }
}

    
