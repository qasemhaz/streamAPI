using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamCrew
    {
        List<Streamcrew> GetAll();
        Streamcrew GetById(int id);
        void Create(Streamcrew stream);
        void Update(Streamcrew stream);
        void Delete(int id);
    }
}
