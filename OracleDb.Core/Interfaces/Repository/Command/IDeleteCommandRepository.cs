using System.Collections.Generic;
using System.Threading.Tasks;

namespace OracleDb.Core.Interfaces.Repository.Command
{
	public interface IDeleteCommandRepository<T>
        where T : class
    {
        Task DeleteAsync(T entity);

        Task DeleteListAsync(ICollection<T> entityList);

    }
}