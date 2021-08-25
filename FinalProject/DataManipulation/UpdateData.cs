using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataManipulation
{
    class UpdateData
    {
        RegisteModule.dataBases.Conection con = new RegisteModule.dataBases.Conection();
        SqlCommand cmd = new SqlCommand();
        public string message;
        public void update(string name, string login, string email, string pass, string sector)
        {

            cmd.CommandText = "UPDATE SimpleRegistration SET NAME=@name, LOGIN=@login, EMAIL=@email, PASSWORD=@pass, SECTOR=@sector";
            //params
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@sector", sector);
            

            try
            {
                cmd.Connection = con.connection();
                cmd.ExecuteNonQuery();
                con.connection();
                this.message = "Registration updated successfully";

            }
            catch (SqlException e)
            {
                this.message = "Error when trying to connecting in the database" + e;
            }



        }
    }
}
