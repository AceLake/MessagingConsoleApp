﻿using Messaging_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_app.DAOs
{
    interface IConversationDAO
    {
        public void CreateConversation(ConversationModel conversation);
        public ConversationModel GetConversationByID(int conversationId);
        public ConversationModel GetConversationByTitle(string conversationTitle);
        public void UpdateConversation(ConversationModel conversation);
        public void DeleteConversation(int conversationId);
    }
}
