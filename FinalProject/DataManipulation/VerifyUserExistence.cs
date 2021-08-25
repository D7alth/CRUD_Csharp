using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManipulation
{
    public class VerifyUserExistence
    {
        RegisteModule.dataBases.Conection con = new RegisteModule.dataBases.Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;
        public bool state;
        public bool verifyUserExistence(string login)
        {

            cmd.CommandText = "SELECT * FROM SimpleRegistration WHERE [LOGIN] = @login";
            //params
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                cmd.Connection = con.connection();
                SqlDataReader reader = cmd.ExecuteReader();

                //verification
                if (reader.HasRows)
                {
                    this.message = "User found";
                    state = true;
                    con.desconection();
                }
                else
                {
                    this.state = false;
                    this.message = "this admin don't exsit";
                    con.desconection();
                }

            }
            catch (SqlException e)
            {
                this.message = "Error when trying to connecting in the database" + e;
            }

            return state;


        }
    }
}
