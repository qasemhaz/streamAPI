using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IFavService
    {
        List<Streamfav> GetAll();
        Streamfav GetById(int id);
        void Create(Streamfav stream);
        void Update(Streamfav stream);
        void Delete(int id);
    }
}
