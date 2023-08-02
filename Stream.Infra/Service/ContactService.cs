using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class ContactService : IContactService
    {
        private readonly IStreamContact streamContact;
        public ContactService(IStreamContact streamContact)
        {
            this.streamContact = streamContact;
        }

        public void Create(Streamcontact stream)
        {
            streamContact.Create(stream);
        }

        public void Delete(int id)
        {
            streamContact.Delete(id);
        }

        public List<Streamcontact> GetAll()
        {
            return streamContact.GetAll();
        }

        public Streamcontact GetById(int id)
        {
            return streamContact.GetById(id);
        }

        public void Update(Streamcontact stream)
        {
            streamContact.Update(stream);
        }
    }
}
