using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePicture { get; set; }
        public bool Status { get; set; }
        public List<UserModel> Contacts { get; set; }
        public string Preferences { get; set; }
        public List<MessageModel> History { get; set; }
        public List<ConversationModel> Groups { get; set; }

        public UserModel()
        {
        }

        public UserModel(string username, string password, string emailAddress, string profilePicture, bool status, List<UserModel> contacts, string preferences, List<MessageModel> history, List<ConversationModel> groups)
        {
            Username = username;
            Password = password;
            EmailAddress = emailAddress;
            ProfilePicture = profilePicture;
            Status = status;
            Contacts = contacts;
            Preferences = preferences;
            History = history;
            Groups = groups;
        }
    }
}
