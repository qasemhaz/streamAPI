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
    public class StreamHome : IStreamHome
    {
        public readonly IDbContext dbContext;
        public StreamHome(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamhome stream)
        {
            var p = new DynamicParameters();
            p.Add("image", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("namee", stream.Namee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rate", stream.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("duartion", stream.Duartion, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("descrip", stream.Descrip, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cat", stream.Cat, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("auth", stream.Auth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("company", stream.Company, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("actor", stream.Actor, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamhome_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamhome_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamhome> GetAll()
        {
            IEnumerable<Streamhome> result = dbContext.Connection.Query<Streamhome>("streamhome_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamhome GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamhome> result = dbContext.Connection.Query<Streamhome>("streamhome_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamhome stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("image1", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("namee1", stream.Namee, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rate1", stream.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("duartion1", stream.Duartion, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("descrip1", stream.Descrip, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cat1", stream.Cat, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("auth1", stream.Auth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("company1", stream.Company, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("actor1", stream.Actor, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamhome_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
