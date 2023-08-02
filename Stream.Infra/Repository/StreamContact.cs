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
    public class StreamContact : IStreamContact
    {
        public readonly IDbContext dbContext;
        public StreamContact(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Streamcontact stream)
        {
            var p = new DynamicParameters();
            p.Add("firstname", stream.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lastname", stream.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phonenumber", stream.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("message", stream.Message, dbType: DbType.String, direction: ParameterDirection.Input);
           

            var result = dbContext.Connection.Execute("streamcontact_package.inserts", p, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("streamcontact_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Streamcontact> GetAll()
        {
            IEnumerable<Streamcontact> result = dbContext.Connection.Query<Streamcontact>("streamcontact_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Streamcontact GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Streamcontact> result = dbContext.Connection.Query<Streamcontact>("streamcontact_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Update(Streamcontact stream)
        {
            var p = new DynamicParameters();
            p.Add("id1", stream.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("firstname1", stream.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lastname1", stream.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phonenumber1", stream.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email1", stream.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("message1", stream.Message, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.Execute("streamcontact_package.updates", p, commandType: CommandType.StoredProcedure);
        }
    }
}
