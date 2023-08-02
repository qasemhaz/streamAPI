using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class AboutService : IAboutService
    {
        private readonly IStreamAbout streamAbout;
        public AboutService(IStreamAbout streamAbout)
        {
            this.streamAbout = streamAbout;
        }

        public void Create(Streamabout stream)
        {
            streamAbout.Create(stream);
        }

        public void Delete(int id)
        {
            streamAbout.Delete(id);
        }

        public List<Streamabout> GetAll()
        {
            return streamAbout.GetAll();
        }

        public Streamabout GetById(int id)
        {
            return streamAbout.GetById(id);
        }

        public void Update(Streamabout stream)
        {
            streamAbout.Update(stream);
        }
    }
}
