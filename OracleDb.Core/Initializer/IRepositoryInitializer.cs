using OracleDb.Core.Interfaces;
using System.Data.Entity;

namespace OracleDb.Core.Initializer
{
    public interface IRepositoryInitializer<T>
            where T : class, IEntity
    {
        DbSet<T> GetDbSet();
    }
}
