using ChatExample.Mediator;
using System.Collections.Generic;

namespace ChatExample.Members
{
    public abstract class Member
    {
        private IMediator<Member, MessageType> _chat;

        public Dictionary<MessageType, string> Messages { get; protected set; }
        public Dictionary<MessageType, string> Responses { get; protected set; }

        public void RegisterChat(IMediator<Member, MessageType> chat) => _chat = chat;
        public void Send(MessageType messageType) => _chat.Send(this, messageType);
        public void Send<T>(MessageType messageType) where T : Member => _chat.Send<T>(this, messageType);

        public abstract void Receive(MessageType messageType);
    }
}
