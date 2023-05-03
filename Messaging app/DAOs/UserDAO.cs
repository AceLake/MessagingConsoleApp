using Messaging_app.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    internal class UserDAO : IUserDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=assemblage;";
        public int CreateUser(UserModel user)
        {
            //INSERT INTO `users` (`ID`, `Username`, `EmailAddress`, `Password`, `ProfilePicture`, `Status`, `Preferences`) VALUES (NULL, 'VictorVindictor', 'DoubleVdevi@gmail.com', 'VVVictorHonty', 'https://open.spotify.com/playlist/6CkIz9hPb0J1rPDb8tAJx1', '0', 'English');
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`ID`, `Username`, `EmailAddress`, `Password`, `ProfilePicture`, `Status`, `Preferences`) VALUES (NULL, @username, @email, @password, @profilepic, @status, @preferences)", connection);

            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@email", user.EmailAddress);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@profilepic", user.ProfilePicture);
            command.Parameters.AddWithValue("@status", user.Status);
            command.Parameters.AddWithValue("@preferences", user.Preferences);

            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }

        public int DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByUsernameAndPassword(string username, string password)
        {
            UserModel returnThis = new UserModel();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE Username = @username and Password = @password", connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserModel a = new UserModel
                    {
                        ID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        EmailAddress = reader.GetString(2),
                        Password = reader.GetString(3),
                        ProfilePicture = reader.GetString(4),
                        Status = reader.GetBoolean(5),
                        Preferences = reader.GetString(6)                       
                    };
                }
            }
            connection.Close();
            return returnThis;
        }

        public int UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUserByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
