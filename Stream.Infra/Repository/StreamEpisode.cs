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
    public class StreamEpisode : IStreamEpisode
    {
        public readonly IDbContext dbContext;
        public StreamEpisode(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamepisode stream)
        {
            var p = new DynamicParameters();
            p.Add("SERIESID", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeNum", stream.Episodenum, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMEPISODE_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMEPISODE_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamepisode> GetAll()
        {
            IEnumerable<Streamepisode> result = dbContext.Connection.Query<Streamepisode>("STREAMEPISODE_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamepisode GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamepisode> result = dbContext.Connection.Query<Streamepisode>("STREAMEPISODE_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamepisode stream)
        {
            var p = new DynamicParameters();
            p.Add("SERIESID1", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("episodeNum1", stream.Episodenum, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMEPISODE_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
