using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteModule.dataBases
{
    class SendData
    {
        Conection c = new Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;

        public SendData(string name, string login, string email, string password, string sector)
        {
            cmd.CommandText = "INSERT INTO SimpleRegistration (NAME, LOGIN, EMAIL, PASSWORD, SECTOR) VALUES (@NAME, @LOGIN, @EMAIL, @PASSWORD, @SECTOR)";
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@SECTOR", sector);

            try
            {
                cmd.Connection = c.connection();
                cmd.ExecuteNonQuery();
                c.desconection();
                this.message = "registered successfully";
            }
            catch(SqlException e)
            {
                this.message = "error when trying to register in the database" + e;
            }
         
            
        }
    }
}
