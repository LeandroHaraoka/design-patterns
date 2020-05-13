using ChatExample.Chats;
using ChatExample.Mediator;
using ChatExample.Members;
using System;

namespace ChatExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator");
            Console.WriteLine("Chat Mediator Example");

            var developer = new Developer();
            var techlead = new TechLead();
            var productManager = new ProductManager();

            var chat = new Chat();
            chat.Register(developer, techlead, productManager);

            productManager.Send(MessageType.Greetings);

            techlead.Send<Developer>(MessageType.Tasks);
            developer.Send<ProductManager>(MessageType.Tasks);
            productManager.Send<TechLead>(MessageType.Tasks);

            developer.Send(MessageType.Goodbyes);


        }
    }
}
