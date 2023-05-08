using Messaging_app.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    class MessageDAO : IMessageDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=assemblage;";
        public void CreateMessage(MessageModel message)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO messages(Content, TimeStamp, UserID, conversatioID) VALUES(@Content, @TimeStamp, @UserID, @ConversationID)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Content", message.Content);
                    command.Parameters.AddWithValue("@TimeStamp", message.TimeStamp);
                    command.Parameters.AddWithValue("@UserID", message.ID);
                    command.Parameters.AddWithValue("@ConversationID", message.ConversationID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMessage(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM messages WHERE ID = @ID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<MessageModel> GetMessageByConversationID(int conversationID)
        {
            List<MessageModel> messages = new List<MessageModel>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM messages WHERE ConversationID = @ConversationID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ConversationID", conversationID);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageModel message = new MessageModel
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Content = reader["Content"].ToString(),
                                TimeStamp = Convert.ToDateTime(reader["TimeStamp"]),
                                SenderID = Convert.ToInt32(reader["UserID"]),
                                ConversationID = Convert.ToInt32(reader["ConversationID"])
                            };
                            messages.Add(message);
                        }
                    }
                }
            }
            return messages;
        }

        public MessageModel GetMessageByUserID(int userID)
        {
            MessageModel message = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM messages WHERE UserID = @UserID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            message = new MessageModel
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Content = reader["Content"].ToString(),
                                TimeStamp = Convert.ToDateTime(reader["TimeStamp"]),
                                SenderID = Convert.ToInt32(reader["UserID"]),
                                ConversationID = Convert.ToInt32(reader["ConversatioID"])
                            };
                        }
                    }
                }
            }
            return message;
        }

        public void UpdateMessage(MessageModel message)
        {
            // Create connection and command objects
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand("UPDATE messages SET Content = @content, TimeStamp = @timeStamp WHERE ID = @id", connection))
            {
                // Add parameters to command
                command.Parameters.AddWithValue("@id", message.ID);
                command.Parameters.AddWithValue("@content", message.Content);
                command.Parameters.AddWithValue("@timeStamp", message.TimeStamp);

                // Open connection and execute command
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
