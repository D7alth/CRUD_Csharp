using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteModule.dataBases
{
   public class Conection
    {
        SqlConnection con = new SqlConnection(); 
        public Conection()
        {
            con.ConnectionString = "Data Source=DESKTOP-2LP5M1V;Initial Catalog=FinalProjectDB;Integrated Security=True";
        }
        public SqlConnection connection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconection()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
