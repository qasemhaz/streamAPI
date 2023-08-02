using Dapper;
using Stream.Core.Common;
using Stream.Core.Data;
using Stream.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Stream.Infra.Repository
{
    public class StreamUser : IStreamUser
    {
        public readonly IDbContext dbContext;
        public StreamUser(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamuser stream)
        {
            var p = new DynamicParameters();
            p.Add("NAME", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONE", stream.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("STREAMUSER_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMUSER_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamuser> GetAll()
        {
            IEnumerable<Streamuser> result = dbContext.Connection.Query<Streamuser>("STREAMUSER_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamuser GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamuser> result = dbContext.Connection.Query<Streamuser>("STREAMUSER_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamuser stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("NAME1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONE1", stream.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL1", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE1", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMUSER_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
