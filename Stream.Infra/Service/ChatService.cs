using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class ChatService : IChatService
    {
        private readonly IStreamChat streamChat;
        public ChatService(IStreamChat streamChat)
        {
            this.streamChat = streamChat;
        }

        public void Create(Streamchat stream)
        {
            streamChat.Create(stream);
        }

        public void Delete(int id)
        {
            streamChat.Delete(id);
        }

        public List<Streamchat> GetAll()
        {
            return streamChat.GetAll();
        }

        public Streamchat GetById(int id)
        {
            return streamChat.GetById(id);
        }

        public void Update(Streamchat stream)
        {
            streamChat.Update(stream);
        }
    }
}
