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
    public class StreamMovie : IStreamMovie
    {
        public readonly IDbContext dbContext;
        public StreamMovie(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streammovie stream)
        {
            var p = new DynamicParameters();
            p.Add("NAME", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RATE", stream.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DURAATION", stream.Duraation, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRODUCTIONYEAR", stream.Productionyear, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("IMAGE", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TRAILER", stream.Trailer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TRAILERLINK", stream.Trailerlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DISCREPTION", stream.Discreption, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("REVIEWS", stream.Reviews, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CATEGORYID", stream.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NUMOFVIEWS", stream.Numofviews, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMMOVIE_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMMOVIE_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streammovie> GetAll()
        {
            IEnumerable<Streammovie> result = dbContext.Connection.Query<Streammovie>("STREAMMOVIE_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streammovie GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streammovie> result = dbContext.Connection.Query<Streammovie>("STREAMMOVIE_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streammovie stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NAME1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RATE1", stream.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DURAATION1", stream.Duraation, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PRODUCTIONYEAR1", stream.Productionyear, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("IMAGE1", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TRAILER1", stream.Trailer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TRAILERLINK1", stream.Trailerlink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DISCREPTION1", stream.Discreption, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("REVIEWS1", stream.Reviews, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CATEGORYID1", stream.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NUMOFVIEWS1", stream.Numofviews, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMMOVIE_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
