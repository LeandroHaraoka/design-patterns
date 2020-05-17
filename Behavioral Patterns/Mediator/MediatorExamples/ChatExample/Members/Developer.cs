using ChatExample.Mediator;
using System;
using System.Collections.Generic;

namespace ChatExample.Members
{
    public class Developer : Member
    {
        public Developer()
        {
            Messages = new Dictionary<MessageType, string>
            {
                { MessageType.Greetings, "Hi." },
                { MessageType.Tasks, "Today I'll fix a bug, finish a code review and deploy a new feature." },
                { MessageType.Goodbyes, "So, let's code?" }
            };

            Responses = new Dictionary<MessageType, string>
            {
                { MessageType.Greetings, "Yo! Talk is cheap, let's code!" },
                { MessageType.Tasks, "Keep calm, the sprint hasn't finished." },
                { MessageType.Goodbyes, "Bye!" }
            };
        }
            
        public override void Receive(MessageType messageType)
        {
            var response = Responses[messageType];
            Console.WriteLine($"Developer: {response}");
        }
    }
}
