using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManipulation
{
    class QueryDelete
    {
        RegisteModule.dataBases.Conection con = new RegisteModule.dataBases.Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;
        public bool state;
        public void delete(string login)
        {

            cmd.CommandText = "DELETE FROM SimpleRegistration WHERE [LOGIN] = @login";
            //params
            cmd.Parameters.AddWithValue("@login", login);
           

            try
            {
                cmd.Connection = con.connection();
                SqlDataReader reader = cmd.ExecuteReader();
                this.message = "successfully data Deleted";
                while (reader.Read())
                {
                }con.desconection();
                 
              
            }
            catch (SqlException e)
            {
                this.message = "Error when trying to connecting in the database" + e;
            }

        


        }
    }
}
