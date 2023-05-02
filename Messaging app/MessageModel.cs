using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app
{
    internal class MessageModel
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int ConversationID { get; set; }
        public string Content { get; set; }
        public DateTime TimeStammp { get; set; }

        public MessageModel()
        {
        }

        public MessageModel(int senderID, int conversationID, string content, DateTime timeStammp)
        {
            SenderID = senderID;
            ConversationID = conversationID;
            Content = content;
            TimeStammp = timeStammp;
        }
    }
}
