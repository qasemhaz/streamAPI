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
    public class StreamPricingUser : IStreampricinguser
    {
    
        public readonly IDbContext dbContext;
        public StreamPricingUser(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streampricinguser stream)
        {
            var p = new DynamicParameters();
            p.Add("userid", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("planid", stream.Planid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("activedate", stream.Activedate, dbType: DbType.Date, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Streampricinguser_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Streampricinguser_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streampricinguser> GetAll()
        {
            IEnumerable<Streampricinguser> result = dbContext.Connection.Query<Streampricinguser>("Streampricinguser_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streampricinguser GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streampricinguser> result = dbContext.Connection.Query<Streampricinguser>("Streampricinguser_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streampricinguser stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("userid1", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("planid1", stream.Planid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("activedate1", stream.Activedate, dbType: DbType.Date, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Streampricinguser_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
