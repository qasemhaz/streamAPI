using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamCategory
    {
        List<Streamcategory> GetAll();
        Streamcategory GetById(int id);
        void Create(Streamcategory stream);
        void Update(Streamcategory stream);
        void Delete(int id);
    }
}
