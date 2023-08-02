using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IStreamRole streamRole;
        public RoleService(IStreamRole streamRole)
        {
            this.streamRole = streamRole;
        }

        public void Create(Streamrole stream)
        {
            streamRole.Create(stream);
        }

        public void Delete(int id)
        {
            streamRole.Delete(id);
        }

        public List<Streamrole> GetAll()
        {
            return streamRole.GetAll();
        }

        public Streamrole GetById(int id)
        {
            return streamRole.GetById(id);
        }

        public void Update(Streamrole stream)
        {
            streamRole.Update(stream);
        }
    }
}
