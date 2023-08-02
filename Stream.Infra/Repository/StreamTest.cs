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
    public class StreamTest : IStreamTest
    {
        public readonly IDbContext dbContext;
        public StreamTest(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Streamtest stream)
        {
            var p = new DynamicParameters();
            p.Add("comments", stream.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rate", stream.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("USERID", stream.Userid, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("status", stream.Status, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("StreamTest_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("StreamTest_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamtest> GetAll()
        {
            IEnumerable<Streamtest> result = dbContext.Connection.Query<Streamtest>("StreamTest_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamtest GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamtest> result = dbContext.Connection.Query<Streamtest>("StreamTest_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamtest stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("comments1", stream.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rate1", stream.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("USERID1", stream.Userid, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("status1", stream.Status, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("StreamTest_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
