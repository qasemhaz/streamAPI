using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamEpisode
    {
        List<Streamepisode> GetAll();
        Streamepisode GetById(int id);
        void Create(Streamepisode stream);
        void Update(Streamepisode stream);
        void Delete(int id);
    }
}
