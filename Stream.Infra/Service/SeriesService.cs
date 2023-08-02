using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class SeriesService : ISeriesService
    {
        private readonly IStreamSeries streamSeries;
        public SeriesService(IStreamSeries streamSeries)
        {
            this.streamSeries = streamSeries;
        }

        public void Create(Streamseries stream)
        {
            streamSeries.Create(stream);
        }

        public void Delete(int id)
        {
            streamSeries.Delete(id);
        }

        public List<Streamseries> GetAll()
        {
            return streamSeries.GetAll();
        }

        public Streamseries GetById(int id)
        {
            return streamSeries.GetById(id);
        }

        public void Update(Streamseries stream)
        {
            streamSeries.Update(stream);
        }
    }
}
