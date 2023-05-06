using Messaging_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    interface IMessageDAO
    {
        public void CreateMessage(MessageModel message);
        public MessageModel GetMessage(int id);
        public void UpdateMessage(MessageModel message);
        public void DeleteMessage(int id);
    }
}
