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
    public class StreamFooter : IStreamFooter
    {
        public readonly IDbContext dbContext;
        public StreamFooter(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamfooter stream)
        {
            var p = new DynamicParameters();
            p.Add("facebook", stream.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("twitter", stream.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("instagram", stream.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("youtube", stream.Youtube, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("play", stream.Play, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("apple", stream.Apple, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address", stream.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONE", stream.Phone, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamfooter_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamfooter_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamfooter> GetAll()
        {
            IEnumerable<Streamfooter> result = dbContext.Connection.Query<Streamfooter>("streamfooter_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamfooter GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamfooter> result = dbContext.Connection.Query<Streamfooter>("streamfooter_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamfooter stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("facebook1", stream.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("twitter1", stream.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("instagram1", stream.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("youtube1", stream.Youtube, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("play1", stream.Play, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("apple1", stream.Apple, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address1", stream.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL1", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONE1", stream.Phone, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("streamfooter_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
