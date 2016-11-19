using OracleDb.Core.Initializer;
using OracleDb.Core.Interfaces;

namespace OracleDb.Repository.Query
{
    public class QueryRepository<T> : QueryRepositoryBase<T>
        where T : class, IEntity
    {
        public QueryRepository(IRepositoryInitializer<T> initializer) :
            base(initializer)
        {
        }
    }
}
