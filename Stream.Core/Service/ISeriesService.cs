using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface ISeriesService
    {
        List<Streamseries> GetAll();
        Streamseries GetById(int id);
        void Create(Streamseries stream);
        void Update(Streamseries stream);
        void Delete(int id);
    }
}
