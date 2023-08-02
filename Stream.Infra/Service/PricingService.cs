using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stream.Infra.Service
{
    public class PricingService : IPricingService
    {
        private readonly IStreampricing streampricing;
        public PricingService(IStreampricing streampricing)
        {
            this.streampricing = streampricing;
        }

        public void Create(Streampricing stream)
        {
            streampricing.Create(stream);
        }

        public void Delete(int id)
        {
            streampricing.Delete(id);
        }

        public List<Streampricing> GetAll()
        {
            return streampricing.GetAll();
        }

        public Streampricing GetById(int id)
        {
            return streampricing.GetById(id);
        }

        public void Update(Streampricing stream)
        {
            streampricing.Update(stream);
        }
    }
}
