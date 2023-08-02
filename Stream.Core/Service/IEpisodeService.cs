using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IEpisodeService
    {
        List<Streamepisode> GetAll();
        Streamepisode GetById(int id);
        void Create(Streamepisode stream);
        void Update(Streamepisode stream);
        void Delete(int id);
    }
}
