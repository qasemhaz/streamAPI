using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IStreamEpisode streamEpisode;
        public EpisodeService(IStreamEpisode streamEpisode)
        {
            this.streamEpisode = streamEpisode;
        }

        public void Create(Streamepisode stream)
        {
            streamEpisode.Create(stream);
        }

        public void Delete(int id)
        {
            streamEpisode.Delete(id);
        }

        public List<Streamepisode> GetAll()
        {
            return streamEpisode.GetAll();
        }

        public Streamepisode GetById(int id)
        {
            return streamEpisode.GetById(id);
        }

        public void Update(Streamepisode stream)
        {
            streamEpisode.Update(stream);
        }
    }
}
