using Messaging_app.Models;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    public class ConversationDAO : IConversationDAO
    {
        private readonly string connectionString;

        public ConversationDAO()
        {
            this.connectionString = "datasource=localhost;port=8889;username=root;password=root;database=assemblage;";
        }

        public void CreateConversation(ConversationModel conversation)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO conversations (Title, LastMessage, TimeStamp) VALUES (@Title, @LastMessage, @TimeStamp)", connection);
                command.Parameters.AddWithValue("@Title", conversation.Title);
                command.Parameters.AddWithValue("@LastMessage", conversation.LastMessage);
                command.Parameters.AddWithValue("@TimeStamp", conversation.TimeStamp);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteConversation(int conversationId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("DELETE FROM conversations WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", conversationId);

                command.ExecuteNonQuery();
            }
        }

        public ConversationModel GetConversationByID(int conversationId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM conversations WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", conversationId);

                MySqlDataReader reader = command.ExecuteReader();

                ConversationModel conversation = null;

                if (reader.Read())
                {
                    conversation = new ConversationModel
                    {
                        ID = reader.GetInt32("ID"),
                        Title = reader.GetString("Title"),
                        //LastMessage = reader.IsDBNull(reader.GetOrdinal("LastMessage")) ? null : reader.GetString("LastMessage"),
                        TimeStamp = reader.GetDateTime("TimeStamp")
                    };
                }

                return conversation;
            }
        }

        public ConversationModel GetConversationByTitle(string conversationTitle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM conversations WHERE Title like @Title", connection);
                command.Parameters.AddWithValue("@Title", "%" + conversationTitle + "%");

                MySqlDataReader reader = command.ExecuteReader();

                ConversationModel conversation = null;

                if (reader.Read())
                {
                    conversation = new ConversationModel
                    {
                        ID = reader.GetInt32("ID"),
                        Title = reader.GetString("Title"),
                        //LastMessage = reader.IsDBNull(reader.GetOrdinal("LastMessage")) ? null : reader.GetString("LastMessage"),
                        TimeStamp = reader.GetDateTime("TimeStamp")
                    };
                }

                return conversation;
            }
        }

        public void UpdateConversation(ConversationModel conversation)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("UPDATE conversations SET Title = @Title, LastMessage = @LastMessage, TimeStamp = @TimeStamp WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", conversation.ID);
                command.Parameters.AddWithValue("@Title", conversation.Title);
                command.Parameters.AddWithValue("@LastMessage", conversation.LastMessage);
                command.Parameters.AddWithValue("@TimeStamp", conversation.TimeStamp);

                command.ExecuteNonQuery();
            }
        }
    }

}
