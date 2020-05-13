using ChatExample.Chats;
using ChatExample.Members;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatExample.Mediator
{
    public class Chat : IMediator<Member, MessageType>
    {
        private readonly List<Member> _members = new List<Member>();

        public void Register(Member member)
        {
            _members.Add(member);
            member.RegisterChat(this);
        }

        public void Register(params Member[] members)
        {
            foreach (var member in members)
            {
                Register(member);
            }
        }

        public void Send(Member from, MessageType messageType)
        {
            var message = from.Messages[messageType];
            Console.WriteLine($"\n{from.GetType().Name} sent: {message}");

            // This only works if from is registered.
            var receivers = _members.Where(member => member != from).ToList();

            receivers.ForEach(m => m.Receive(messageType));
        }

        // TODO: Remove from if it is not necessary
        public void Send<T>(Member from, MessageType messageType) where T : Member
        {
            var message = from.Messages[messageType];
            Console.WriteLine($"\n{from.GetType().Name} sent: {message}");

            // This only works if from is registered.
            _members.OfType<T>().ToList().ForEach(m => m.Receive(messageType));
        }
    }
}
