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
    public class StreamCrew : IStreamCrew
    {
        public readonly IDbContext dbContext;
        public StreamCrew(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamcrew stream)
        {
            var p = new DynamicParameters();
            p.Add("NAME", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCIP", stream.Descip, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FACEBOOK", stream.Facebook, dbType: DbType.String, direction: ParameterDirection.Input); 
            p.Add("TWITER", stream.Twiter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTAGRAM", stream.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AGE", stream.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE", stream.Birthdate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("PLACEOFBIRTH", stream.Placeofbirth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ROLEID", stream.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMCREW_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMCREW_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamcrew> GetAll()
        {
            IEnumerable<Streamcrew> result = dbContext.Connection.Query<Streamcrew>("STREAMCREW_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamcrew GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamcrew> result = dbContext.Connection.Query<Streamcrew>("STREAMCREW_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamcrew stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("NAME1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCIP1", stream.Descip, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE1", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FACEBOOK1", stream.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TWITER1", stream.Twiter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTAGRAM1", stream.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AGE1", stream.Age, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE1", stream.Birthdate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("PLACEOFBIRTH1", stream.Placeofbirth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ROLEID1", stream.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMCREW_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
