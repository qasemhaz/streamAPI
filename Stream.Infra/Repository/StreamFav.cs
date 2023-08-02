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
    public class StreamFav : IStreamFav
    {
        public readonly IDbContext dbContext;
        public StreamFav(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamfav stream)
        {
            var p = new DynamicParameters();
            p.Add("movieid", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("seriesid", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeid", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userid", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            

            var result = dbContext.Connection.Execute("streamfav_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamfav_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamfav> GetAll()
        {
            IEnumerable<Streamfav> result = dbContext.Connection.Query<Streamfav>("streamfav_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamfav GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamfav> result = dbContext.Connection.Query<Streamfav>("streamfav_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamfav stream)
        {
            var p = new DynamicParameters();
            p.Add("movieid1", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("seriesid1", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeid1", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userid1", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamfav_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
