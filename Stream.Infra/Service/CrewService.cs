using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class CrewService : ICrewService
    {
        private readonly IStreamCrew streamCrew;
        public CrewService(IStreamCrew streamCrew)
        {
            this.streamCrew = streamCrew;
        }

        public void Create(Streamcrew stream)
        {
            streamCrew.Create(stream);
        }

        public void Delete(int id)
        {
            streamCrew.Delete(id);
        }

        public List<Streamcrew> GetAll()
        {
            return streamCrew.GetAll();
        }

        public Streamcrew GetById(int id)
        {
            return streamCrew.GetById(id);
        }

        public void Update(Streamcrew stream)
        {
            streamCrew.Update(stream);
        }
    }
}
