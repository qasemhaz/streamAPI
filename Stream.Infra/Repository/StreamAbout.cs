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
    public class StreamAbout : IStreamAbout
    {
        public readonly IDbContext dbContext;
        public StreamAbout(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Streamabout stream)
        {
            var p = new DynamicParameters();
            p.Add("header", stream.Header, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("header2", stream.Header2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("header3", stream.Header3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("par1", stream.Par1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("par2", stream.Par2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("branch", stream.Branch, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("employee", stream.Employee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("clint", stream.Clint, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamabout_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamabout_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamabout> GetAll()
        {
            IEnumerable<Streamabout> result = dbContext.Connection.Query<Streamabout>("streamabout_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamabout GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamabout> result = dbContext.Connection.Query<Streamabout>("streamabout_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamabout stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("header1", stream.Header, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("header21", stream.Header2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("header31", stream.Header3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("par11", stream.Par1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("par21", stream.Par2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("branch1", stream.Branch, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("employee1", stream.Employee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("clint1", stream.Clint, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamabout_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
