namespace OracleDb.Core.Interfaces.Repository.Command
{
	public interface ICommandRepository<T> : IUpdateCommandRepository<T>, IAddCommandRepository<T>, IDeleteCommandRepository<T>
		where T : class, IEntity
	{
	}
}
