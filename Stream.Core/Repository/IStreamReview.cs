using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamReview
    {
        List<Streamreview> GetAll();
        Streamreview GetById(int id);
        void Create(Streamreview stream);
        void Update(Streamreview stream);
        void Delete(int id);
    }
}
