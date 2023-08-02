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
    public class StreamWatchLater : IStreamWatchLater
    {
        public readonly IDbContext dbContext;
        public StreamWatchLater(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamwatchlater stream)
        {
            var p = new DynamicParameters();
            p.Add("movieid", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("seriesid", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeid", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userid", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("streamwatchlater_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamwatchlater_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamwatchlater> GetAll()
        {
            IEnumerable<Streamwatchlater> result = dbContext.Connection.Query<Streamwatchlater>("streamwatchlater_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamwatchlater GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamwatchlater> result = dbContext.Connection.Query<Streamwatchlater>("streamwatchlater_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamwatchlater stream)
        {
            var p = new DynamicParameters();
            p.Add("movieid1", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("seriesid1", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeid1", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userid1", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamwatchlater_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
