using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class WatchLaterService : IWatchLaterService
    {
        private readonly IStreamWatchLater streamWatchLater;
        public WatchLaterService(IStreamWatchLater streamWatchLater)
        {
            this.streamWatchLater = streamWatchLater;
        }

        public void Create(Streamwatchlater stream)
        {
            streamWatchLater.Create(stream);
        }

        public void Delete(int id)
        {
            streamWatchLater.Delete(id);
        }

        public List<Streamwatchlater> GetAll()
        {
            return streamWatchLater.GetAll();
        }

        public Streamwatchlater GetById(int id)
        {
            return streamWatchLater.GetById(id);
        }

        public void Update(Streamwatchlater stream)
        {
            streamWatchLater.Update(stream);
        }
    }
}