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
    public class FooterService : IFooterService
    {
        private readonly IStreamFooter streamFooter;
        public FooterService(IStreamFooter streamFooter)
        {
            this.streamFooter = streamFooter;
        }

        public void Create(Streamfooter stream)
        {
            streamFooter.Create(stream);
        }

        public void Delete(int id)
        {
            streamFooter.Delete(id);
        }

        public List<Streamfooter> GetAll()
        {
            return streamFooter.GetAll();
        }

        public Streamfooter GetById(int id)
        {
            return streamFooter.GetById(id);
        }

        public void Update(Streamfooter stream)
        {
            streamFooter.Update(stream);
        }
    }
}
