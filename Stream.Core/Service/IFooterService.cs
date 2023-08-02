using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IFooterService
    {
        List<Streamfooter> GetAll();
        Streamfooter GetById(int id);
        void Create(Streamfooter stream);
        void Update(Streamfooter stream);
        void Delete(int id);
    }
}
