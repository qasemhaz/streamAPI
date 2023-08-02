using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IHomeService
    {
        List<Streamhome> GetAll();
        Streamhome GetById(int id);
        void Create(Streamhome stream);
        void Update(Streamhome stream);
        void Delete(int id);
    }
}
