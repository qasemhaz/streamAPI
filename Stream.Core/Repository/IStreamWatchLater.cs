using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Repository
{
    public interface IStreamWatchLater
    {
        List<Streamwatchlater> GetAll();
        Streamwatchlater GetById(int id);
        void Create(Streamwatchlater stream);
        void Update(Streamwatchlater stream);
        void Delete(int id);
    }
}
