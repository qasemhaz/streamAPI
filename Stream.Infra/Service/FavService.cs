using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class FavService : IFavService
    {
        private readonly IStreamFav streamFav;
        public FavService(IStreamFav streamFav)
        {
            this.streamFav = streamFav;
        }

        public void Create(Streamfav stream)
        {
            streamFav.Create(stream);
        }

        public void Delete(int id)
        {
            streamFav.Delete(id);
        }

        public List<Streamfav> GetAll()
        {
            return streamFav.GetAll();
        }

        public Streamfav GetById(int id)
        {
            return streamFav.GetById(id);
        }

        public void Update(Streamfav stream)
        {
            streamFav.Update(stream);
        }
    }
}
