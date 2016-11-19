using System.Collections.Generic;
using System.Threading.Tasks;

namespace OracleDb.Core.Interfaces.Repository.Command
{
	public interface IAddCommandRepository<T>
        where T : class
    {
        Task AddAsync(T entity);

        Task AddListAsync(ICollection<T> entityList);
    }
}
