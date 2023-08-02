using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IStreamUser streamUser;
        public UserService(IStreamUser streamUser)
        {
            this.streamUser = streamUser;
        }

        public void Create(Streamuser stream)
        {
            streamUser.Create(stream);
        }

        public void Delete(int id)
        {
            streamUser.Delete(id);
        }

        public List<Streamuser> GetAll()
        {
            return streamUser.GetAll();
        }

        public Streamuser GetById(int id)
        {
            return streamUser.GetById(id);
        }

        public void Update(Streamuser stream)
        {
            streamUser.Update(stream);
        }
    }
}
