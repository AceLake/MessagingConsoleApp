using Messaging_app.Models;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    class ConversationDAO : IConversationDAO
    {
        public void CreateConversation(ConversationModel conversation)
        {
            // INSERT INTO `conversations` (`ID`, `Title`, `LastMessage`, `TimeStamp`) VALUES (NULL, 'The Gals', NULL, '2023-05-05');
            throw new NotImplementedException();
        }

        public void DeleteConversation(int conversationId)
        {
            // DELETE FROM conversations WHERE `conversations`.`ID` = 2
            throw new NotImplementedException();
        }
        public ConversationModel GetConversationByID(int conversationId)
        {
            // SELECT * FROM `conversations` WHERE ID = 2
            throw new NotImplementedException();
        }

        public ConversationModel GetConversationByTitle(string conversationTitle)
        {
            // SELECT * FROM `conversations` WHERE Title like "%The%"
            throw new NotImplementedException();
        }

        public void UpdateConversation(ConversationModel conversation)
        {
            // UPDATE `conversations` SET `Title` = 'The Gals!', `LastMessage` = 'When we meeting tonight again sorry?', `TimeStamp` = '2023-05-06' WHERE `conversations`.`ID` = 2
            throw new NotImplementedException();
        }
    }
}
