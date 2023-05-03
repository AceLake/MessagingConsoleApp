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
