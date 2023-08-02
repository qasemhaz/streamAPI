using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class SourceService : ISourceService
    {
        private readonly IStreamSource streamSource;
        public SourceService(IStreamSource streamSource)
        {
            this.streamSource = streamSource;
        }

        public void Create(Streamsource stream)
        {
            streamSource.Create(stream);
        }

        public void Delete(int id)
        {
            streamSource.Delete(id);
        }

        public List<Streamsource> GetAll()
        {
            return streamSource.GetAll();
        }

        public Streamsource GetById(int id)
        {
            return streamSource.GetById(id);
        }

        public void Update(Streamsource stream)
        {
            streamSource.Update(stream);
        }
    }
}
