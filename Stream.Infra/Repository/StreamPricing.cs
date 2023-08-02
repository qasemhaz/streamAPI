using Dapper;
using Stream.Core.Common;
using Stream.Core.Data;
using Stream.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Stream.Infra.Repository
{
    public class StreamPricing : IStreampricing
    {
        public readonly IDbContext dbContext;
        public StreamPricing(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streampricing stream)
        {
            var p = new DynamicParameters();
            p.Add("name", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("price", stream.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("periodd", stream.Periodd, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Streampricing_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Streampricing_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streampricing> GetAll()
        {
            IEnumerable<Streampricing> result = dbContext.Connection.Query<Streampricing>("Streampricing_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streampricing GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streampricing> result = dbContext.Connection.Query<Streampricing>("Streampricing_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streampricing stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("name1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("price1", stream.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("periodd1", stream.Periodd, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Streampricing_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
