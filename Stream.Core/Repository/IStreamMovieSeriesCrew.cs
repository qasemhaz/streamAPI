using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamMovieSeriesCrew
    {
        List<Streammovieseriescrew> GetAll();
        Streammovieseriescrew GetById(int id);
        void Create(Streammovieseriescrew stream);
        void Update(Streammovieseriescrew stream);
        void Delete(int id);
    }
}
