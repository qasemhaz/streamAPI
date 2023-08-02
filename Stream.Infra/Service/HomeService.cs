using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Stream.Infra.Service
{
    public class HomeService : IHomeService
    {
        private readonly IStreamHome streamHome;
        public HomeService(IStreamHome streamHome)
        {
            this.streamHome = streamHome;
        }

        public void Create(Streamhome stream)
        {
            streamHome.Create(stream);
        }

        public void Delete(int id)
        {
            streamHome.Delete(id);
        }

        public List<Streamhome> GetAll()
        {
            return streamHome.GetAll();
        }

        public Streamhome GetById(int id)
        {
            return streamHome.GetById(id);
        }

        public void Update(Streamhome stream)
        {
            streamHome.Update(stream);
        }
    }
}
