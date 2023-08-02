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
    public class StreamMovieSeriesCrew : IStreamMovieSeriesCrew
    {
        public readonly IDbContext dbContext;
        public StreamMovieSeriesCrew(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streammovieseriescrew stream)
        {
            var p = new DynamicParameters();
            p.Add("CREWID", stream.Crewid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("MOVIEID", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SERIESID", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("STREAMMOVIESERIESCREW_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMMOVIESERIESCREW_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streammovieseriescrew> GetAll()
        {
            IEnumerable<Streammovieseriescrew> result = dbContext.Connection.Query<Streammovieseriescrew>("STREAMMOVIESERIESCREW_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streammovieseriescrew GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streammovieseriescrew> result = dbContext.Connection.Query<Streammovieseriescrew>("STREAMMOVIESERIESCREW_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streammovieseriescrew stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("CREWID1", stream.Crewid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("MOVIEID1", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SERIESID1", stream.Seriesid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("STREAMMOVIESERIESCREW_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
