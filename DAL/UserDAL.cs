using DataModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UserDal
    {
        private readonly DalAcces dalAcces = new DalAcces();


        //create
        public bool CreateUser(UserDataModel user)
        {
           bool createdSuccesfull = false;
            dalAcces.conn.Open();
            string query = "INSERT INTO user(email, password, firstname, surname) " +
                            "VALUES (@email, @password,@firstname,@surname)";
            
            MySqlCommand command = new MySqlCommand(query, dalAcces.conn);
            command.Parameters.Add(new MySqlParameter("@email", user.Email));
            command.Parameters.Add(new MySqlParameter("@password", user.Passsword));
            command.Parameters.Add(new MySqlParameter("@firstname", user.Firstname));
            command.Parameters.Add(new MySqlParameter("@surname", user.Surname));
           
           
            try
            {
                command.ExecuteNonQuery();
                if (command.ExecuteNonQuery().Equals(1))
                {
                    dalAcces.conn.Close();
                    createdSuccesfull = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                createdSuccesfull = false;
                throw;

            }
            finally
            {
                dalAcces.conn.Close();
            }
            
            return createdSuccesfull;
        }
        //update

        //delete

        //read
        public UserDataModel Getuser(UserDataModel user)
        {
            dalAcces.conn.Open();
            UserDataModel data = new UserDataModel();
            string query = "Select * FROM user WHERE username = @username";

            MySqlCommand command = new MySqlCommand(query, dalAcces.conn);
            command.Parameters.Add(new MySqlParameter("@username", user.Username));
           

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Username = reader.GetString(1);
                data.Passsword = reader.GetString(2);
            }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dalAcces.conn.Close();
            }
           
            return data;
        }
    }
}
