using OracleDb.Context;
using OracleDb.Core.Interfaces;
using WebApiTypeScript.Data.Repository.Generic.Command;

namespace OracleDb.Repository.Command
{
    public class CommandRepository<T> : EfCommandRepositoryBase<T>
        where T : class, IEntity
    {
        public CommandRepository(DevContext context)
            : base(context)
        {
        }
    }
}
