using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisteModule;

namespace FinalProject.DataManipulation
{
    public class QueryShowDates
    {
        RegisteModule.dataBases.Conection con = new RegisteModule.dataBases.Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;
        public bool state;
       public string txtNameText, txtEmailText, txtSectorText;

        public bool queryShowDates(string login) {
           

        cmd.CommandText = "SELECT [NAME], [EMAIL], [SECTOR], [LOGIN] FROM AdiministratorRegistration WHERE [LOGIN] = @login";
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                cmd.Connection = con.connection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    this.txtNameText = reader.GetString(0);
                    this.txtEmailText = reader.GetString(1);
                    this.txtSectorText = reader.GetString(2);

                    con.desconection();

                    this.message = "okay";
                    return true;
                }
                else
                {
                    this.message = "not okay";
                    con.desconection();
                    return false; 
                }
            }catch(SqlException e)
            {
                this.message = "ops" + e;
                return false;
            }

        }

    }
}
