using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IPricingService
    {
        List<Streampricing> GetAll();
        Streampricing GetById(int id);
        void Create(Streampricing stream);
        void Update(Streampricing stream);
        void Delete(int id);
    }
}
