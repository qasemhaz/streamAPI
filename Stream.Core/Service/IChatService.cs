using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IChatService
    {
        List<Streamchat> GetAll();
        Streamchat GetById(int id);
        void Create(Streamchat stream);
        void Update(Streamchat stream);
        void Delete(int id);
    }
}
