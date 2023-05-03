using Messaging_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    public interface IUserDAO
    {
        List<UserModel> GetAllUsers();
        UserModel GetUserById(int id);
        UserModel GetUserByUserName(string userName);
        UserModel GetUserByUsernameAndPassword(string username, string password);
        bool ValidateUserByUsernameAndPassword(string username, string password);
        int CreateUser(UserModel user);
        int UpdateUser(UserModel user);
        int DeleteUser(int id);
    }
}
