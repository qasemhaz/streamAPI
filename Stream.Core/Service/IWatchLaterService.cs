using Stream.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Service
{
    public interface IWatchLaterService
    {
        List<Streamwatchlater> GetAll();
        Streamwatchlater GetById(int id);
        void Create(Streamwatchlater stream);
        void Update(Streamwatchlater stream);
        void Delete(int id);
    }
}
