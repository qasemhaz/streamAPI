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
    public class StreamCategory : IStreamCategory
    {
        public readonly IDbContext dbContext;
        public StreamCategory(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamcategory stream)
        {
            var p = new DynamicParameters();
            p.Add("catname", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMCATEGORY_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMCATEGORY_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamcategory> GetAll()
        {
            IEnumerable<Streamcategory> result = dbContext.Connection.Query<Streamcategory>("STREAMCATEGORY_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamcategory GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamcategory> result = dbContext.Connection.Query<Streamcategory>("STREAMCATEGORY_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamcategory stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("catname1", stream.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image1", stream.Image, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMCATEGORY_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
