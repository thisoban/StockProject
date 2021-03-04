using DataModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class UserDal
    {
        private readonly DalAcces dalAcces = new DalAcces();


        //create

        //update

        //delete

        //read
        public UserDataModel Getuser(UserDataModel emaildata)
        {
            dalAcces.conn.Open();
            UserDataModel data = new UserDataModel();
            string query = "Select * FROM user WHERE IdUser = @IdUser";

            MySqlCommand command = new MySqlCommand(query, dalAcces.conn);
            command.Parameters.Add(new MySqlParameter("@IdUser", emaildata.Email));

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Email = reader.GetString(2);
                data.Passsword = reader.GetString(3);

            }
            dalAcces.conn.Close();
            return data;
        }
    }
}
