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
    public class StreamChat : IStreamChat
    {
        public readonly IDbContext dbContext;
        public StreamChat(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamchat stream)
        {
            var p = new DynamicParameters();
            p.Add("sender", stream.sender, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("receiver", stream.receiver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("message", stream.message, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("streamchat_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamchat_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamchat> GetAll()
        {
            IEnumerable<Streamchat> result = dbContext.Connection.Query<Streamchat>("streamchat_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamchat GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamchat> result = dbContext.Connection.Query<Streamchat>("streamchat_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamchat stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("sender", stream.sender, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("receiver", stream.receiver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("message", stream.message, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamchat_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
