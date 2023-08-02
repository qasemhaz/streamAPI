using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class MovieService : IMovieService
    {
        private readonly IStreamMovie streamMovie;
        public MovieService(IStreamMovie streamMovie)
        {
            this.streamMovie = streamMovie;
        }

        public void Create(Streammovie stream)
        {
            streamMovie.Create(stream);
        }

        public void Delete(int id)
        {
            streamMovie.Delete(id);
        }

        public List<Streammovie> GetAll()
        {
            return streamMovie.GetAll();
        }

        public Streammovie GetById(int id)
        {
            return streamMovie.GetById(id);
        }

        public void Update(Streammovie stream)
        {
            streamMovie.Update(stream);
        }
    }
}
