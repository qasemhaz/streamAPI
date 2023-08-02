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
    public class StreamReview : IStreamReview
    {
        public readonly IDbContext dbContext;
        public StreamReview(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Streamreview stream)
        {
            var p = new DynamicParameters();
            p.Add("Comments", stream.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Iduser", stream.Iduser, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Idmovie", stream.Idmovie, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Idseries", stream.Idseries, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Streamreview_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Streamreview_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamreview> GetAll()
        {
            IEnumerable<Streamreview> result = dbContext.Connection.Query<Streamreview>("Streamreview_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamreview GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamreview> result = dbContext.Connection.Query<Streamreview>("Streamreview_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamreview stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Comments1", stream.Comments, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Iduser1", stream.Iduser, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Idmovie1", stream.Idmovie, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Idseries1", stream.Idseries, dbType: DbType.Int32, direction: ParameterDirection.Input);
           



            var result = dbContext.Connection.Execute("Streamreview_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
