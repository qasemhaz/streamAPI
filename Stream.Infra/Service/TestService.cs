using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class TestService : ITestService
    {
        private readonly IStreamTest streamTest;
        public TestService(IStreamTest streamTest)
        {
            this.streamTest = streamTest;
        }

        public void Create(Streamtest stream)
        {
            streamTest.Create(stream);
        }

        public void Delete(int id)
        {
            streamTest.Delete(id);
        }

        public List<Streamtest> GetAll()
        {
            return streamTest.GetAll();
        }

        public Streamtest GetById(int id)
        {
            return streamTest.GetById(id);
        }

        public void Update(Streamtest stream)
        {
            streamTest.Update(stream);
        }
    }
}
