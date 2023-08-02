using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamContact
    {
        List<Streamcontact> GetAll();
        Streamcontact GetById(int id);
        void Create(Streamcontact stream);
        void Update(Streamcontact stream);
        void Delete(int id);
    }
}
