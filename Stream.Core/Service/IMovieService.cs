using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IMovieService
    {
        List<Streammovie> GetAll();
        Streammovie GetById(int id);
        void Create(Streammovie stream);
        void Update(Streammovie stream);
        void Delete(int id);
    }
}
