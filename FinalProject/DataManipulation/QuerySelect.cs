using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisteModule; 

namespace FinalProject.DataManipulation
{
   public class QuerySelect
    {
        RegisteModule.dataBases.Conection con = new RegisteModule.dataBases.Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;
        public bool state;
        public bool queryLogin(string login, string pass)
        {
           
            cmd.CommandText = "SELECT * FROM AdiministratorRegistration WHERE [LOGIN] = @login AND [PASSWORD] = @pass";
            //params
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pass", pass);

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
            catch(SqlException e)
            {
                this.message = "Error when trying to connecting in the database" + e;
            }

            return state;


        }
    }
}
