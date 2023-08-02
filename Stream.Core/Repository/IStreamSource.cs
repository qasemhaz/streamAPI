using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamSource
    {
        List<Streamsource> GetAll();
        Streamsource GetById(int id);
        void Create(Streamsource stream);
        void Update(Streamsource stream);
        void Delete(int id);
    }
}
