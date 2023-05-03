using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.Models
{
    public class ConversationModel
    {
        public int ID { get; set; }
        public List<UserModel> Participants { get; set; }
        public string Title { get; set; }
        public MessageModel LastMessage { get; set; }
        public DateTime TimeStamp { get; set; }

        public ConversationModel()
        {
        }

        public ConversationModel(List<UserModel> participants, string title, MessageModel lastMessage, DateTime timeStamp)
        {
            Participants = participants;
            Title = title;
            LastMessage = lastMessage;
            TimeStamp = timeStamp;
        }
    }
}
