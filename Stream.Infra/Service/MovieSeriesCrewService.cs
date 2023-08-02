using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class MovieSeriesCrewService : IMovieSeriesCrewService
    {
        private readonly IStreamMovieSeriesCrew streamMovieSeriesCrew;
        public MovieSeriesCrewService(IStreamMovieSeriesCrew streamMovieSeriesCrew)
        {
            this.streamMovieSeriesCrew = streamMovieSeriesCrew;
        }

        public void Create(Streammovieseriescrew stream)
        {
            streamMovieSeriesCrew.Create(stream);
        }

        public void Delete(int id)
        {
            streamMovieSeriesCrew.Delete(id);
        }

        public List<Streammovieseriescrew> GetAll()
        {
            return streamMovieSeriesCrew.GetAll();
        }

        public Streammovieseriescrew GetById(int id)
        {
            return streamMovieSeriesCrew.GetById(id);
        }

        public void Update(Streammovieseriescrew stream)
        {
            streamMovieSeriesCrew.Update(stream);
        }
    }
}
