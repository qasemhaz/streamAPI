using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IUserService
    {
        List<Streamuser> GetAll();
        Streamuser GetById(int id);
        void Create(Streamuser stream);
        void Update(Streamuser stream);
        void Delete(int id);
    }
}
