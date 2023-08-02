using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreampricinguser
    {
        List<Streampricinguser> GetAll();
        Streampricinguser GetById(int id);
        void Create(Streampricinguser stream);
        void Update(Streampricinguser stream);
        void Delete(int id);
    }
}
