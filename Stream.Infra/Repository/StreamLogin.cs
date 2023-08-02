using Dapper;
using Stream.Core.Common;
using Stream.Core.Data;
using Stream.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Stream.Infra.Repository
{
    public class StreamLogin : IStreamLogin
    {
        public readonly IDbContext dbContext;
        public StreamLogin(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Streamlogin Auth(Streamlogin loginof)
        {
            var p = new DynamicParameters();

            p.Add("username1", loginof.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password1", loginof.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Query<Streamlogin>("STREAMLOGIN_package.auth", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }
        public void Create(Streamlogin stream)
        {
            var p = new DynamicParameters();
            p.Add("USERNAME", stream.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSWORD", stream.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ROLEID", stream.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("USERID", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("STREAMLOGIN_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("STREAMLOGIN_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamlogin> GetAll()
        {
            IEnumerable<Streamlogin> result = dbContext.Connection.Query<Streamlogin>("STREAMLOGIN_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamlogin GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamlogin> result = dbContext.Connection.Query<Streamlogin>("STREAMLOGIN_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void googl(string name, string email, string pass)
        {
            var p = new DynamicParameters();
            p.Add("NAME", name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL", email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSWORD1", pass, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMLOGIN_package.google", p, commandType: CommandType.StoredProcedure);
        }

        public void Update(Streamlogin stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("USERNAME1", stream.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSWORD1", stream.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ROLEID1", stream.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("USERID1", stream.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("STREAMLOGIN_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
