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
    public class StreamRole : IStreamRole
    {
        public readonly IDbContext dbContext;
        public StreamRole(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamrole stream)
        {
            var p = new DynamicParameters();
            p.Add("catname", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            


            var result = dbContext.Connection.Execute("STREAMROLE_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMROLE_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamrole> GetAll()
        {
            IEnumerable<Streamrole> result = dbContext.Connection.Query<Streamrole>("STREAMROLE_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamrole GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamrole> result = dbContext.Connection.Query<Streamrole>("STREAMROLE_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamrole stream)
        {
            var p = new DynamicParameters();
            p.Add("catname1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMROLE_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
