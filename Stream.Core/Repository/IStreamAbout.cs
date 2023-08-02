using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamAbout
    {
        List<Streamabout> GetAll();
        Streamabout GetById(int id);
        void Create(Streamabout stream);
        void Update(Streamabout stream);
        void Delete(int id);
    }
}
