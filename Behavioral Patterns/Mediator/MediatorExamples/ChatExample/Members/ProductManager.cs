using ChatExample.Chats;
using ChatExample.Mediator;
using System;
using System.Collections.Generic;

namespace ChatExample.Members
{
    public class ProductManager : Member
    {
        public ProductManager()
        {
            Messages = new Dictionary<MessageType, string>
            {
                        { MessageType.Greetings, "Sorry for the delay, I was at another meeting." },
                        { MessageType.Tasks, "Today I have two meetings in the afternoon and I intend to finish a feature validation." },
                        { MessageType.Goodbyes, "Sorry I must leave now, client is calling me." }
            };

            Responses = new Dictionary<MessageType, string>
            {
                        { MessageType.Greetings, "Hello" },
                        { MessageType.Tasks, "Please let me know when it's deployed." },
                        { MessageType.Goodbyes, "Bye bye!" }
            };
        }

        public override void Receive(MessageType messageType)
        {
            var response = Responses[messageType];
            Console.WriteLine($"ProductManager: {response}");
        }
    }
}
