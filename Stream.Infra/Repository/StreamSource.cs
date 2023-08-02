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
    public class StreamSource : IStreamSource
    {
        public readonly IDbContext dbContext;
        public StreamSource(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamsource stream)
        {
            var p = new DynamicParameters();
            p.Add("VIDEO", stream.Video, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("QUALITY", stream.Quality, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PLAYER", stream.Player, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LANGUAGEE", stream.Languagee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DATEADDED", stream.Dateadded, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("MOVIEID", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EPISODEID", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
           

            var result = dbContext.Connection.Execute("STREAMSOURCE_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMSOURCE_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamsource> GetAll()
        {
            IEnumerable<Streamsource> result = dbContext.Connection.Query<Streamsource>("STREAMSOURCE_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamsource GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamsource> result = dbContext.Connection.Query<Streamsource>("STREAMSOURCE_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamsource stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("VIDEO1", stream.Video, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("QUALITY1", stream.Quality, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PLAYER1", stream.Player, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LANGUAGEE1", stream.Languagee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DATEADDED1", stream.Dateadded, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("MOVIEID1", stream.Movieid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("EPISODEID1", stream.Episodeid, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMSOURCE_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
