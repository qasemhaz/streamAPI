using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamRole
    {
        List<Streamrole> GetAll();
        Streamrole GetById(int id);
        void Create(Streamrole stream);
        void Update(Streamrole stream);
        void Delete(int id);
    }
}
