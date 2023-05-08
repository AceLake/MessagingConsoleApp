using Messaging_app.DAOs;
using Messaging_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app
{
    public class BusinessLogic
    {
        UserDAO userDAO = new UserDAO();

        // TODO: work on implementing the methods to call all CRUD functions within the app

        MessageDAO messageDAO = new MessageDAO();

        public List<MessageModel> GetAllMessagesInGroup(ConversationModel conversation)
        {
           return messageDAO.GetMessageByConversationID(conversation.ID);
        }

        public void SendMessage(MessageModel content)
        {
            messageDAO.CreateMessage(content);
        }

        public UserModel GetUser(string username, string password)
        {
            return userDAO.GetUserByUsernameAndPassword(username, password);
        }

        public void SaveUser(UserModel user)
        {
            if (userDAO.CreateUser(user) == 1)
            {
                Console.WriteLine(user.Username + " Was Saved");
            }
            else
            {
                Console.WriteLine(user.Username + " Was Not Saved For Some Reason");
            }
        }
    }
}
