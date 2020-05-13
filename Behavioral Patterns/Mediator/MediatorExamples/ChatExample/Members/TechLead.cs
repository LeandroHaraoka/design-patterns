using ChatExample.Chats;
using ChatExample.Mediator;
using System;
using System.Collections.Generic;

namespace ChatExample.Members
{
    public class TechLead : Member
    {
        public TechLead()
        {
            Messages = new Dictionary<MessageType, string>
            {
                        { MessageType.Greetings, "Hello everyone!" },
                        { MessageType.Tasks, "I'm still asking devops team to solve my ticket and in the meanwhile I'll help our devs." },
                        { MessageType.Goodbyes, "See you later!" }
            };
            
            Responses = new Dictionary<MessageType, string>
            {
                        { MessageType.Greetings, "Hey." },
                        { MessageType.Tasks, "Please contact me at your convenience." },
                        { MessageType.Goodbyes, "Ok, see you later." }
            };
        }
        
        public override void Receive(MessageType messageType)
        {
            var response = Responses[messageType];
            Console.WriteLine($"TechLead: {response}");
        }
    }
}
