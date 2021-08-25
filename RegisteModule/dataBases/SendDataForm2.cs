using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteModule.dataBases
{
    class SendDataForm2
    {
        Conection c = new Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;

        public SendDataForm2(string name, string login, string email, string password, string sector, string controlLevel)
        {
            cmd.CommandText = "INSERT INTO AdiministratorRegistration (NAME, LOGIN, EMAIL, PASSWORD, SECTOR, CONTROLLEVEL) VALUES (@NAME, @LOGIN, @EMAIL, @PASSWORD, @SECTOR, @CONROLLEVEL)";
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@SECTOR", sector);
            cmd.Parameters.AddWithValue("@CONROLLEVEL", controlLevel);

            try
            {
                cmd.Connection = c.connection();
                cmd.ExecuteNonQuery();
                c.desconection();
                this.message = "admin registered successfully";
            }
            catch (SqlException e)
            {
                this.message = "error when trying to register in the database" + e;
            }


        }
    }
}
