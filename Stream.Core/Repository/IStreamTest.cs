using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamTest
    {
        List<Streamtest> GetAll();
        Streamtest GetById(int id);
        void Create(Streamtest stream);
        void Update(Streamtest stream);
        void Delete(int id);
    }
}
