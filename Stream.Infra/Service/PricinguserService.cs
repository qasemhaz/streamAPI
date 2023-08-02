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
    public class PricinguserService : IPricinguserService
    {
        private readonly IStreampricinguser streampricinguser;
        public PricinguserService(IStreampricinguser streampricinguser)
        {
            this.streampricinguser = streampricinguser;
        }
        public void Create(Streampricinguser stream)
        {
            streampricinguser.Create(stream);
        }

        public void Delete(int id)
        {
            streampricinguser.Delete(id);
        }

        public List<Streampricinguser> GetAll()
        {
            return streampricinguser.GetAll();
        }

        public Streampricinguser GetById(int id)
        {
            return streampricinguser.GetById(id);
        }

        public void Update(Streampricinguser stream)
        {
            streampricinguser.Update(stream);
        }
    }
}
