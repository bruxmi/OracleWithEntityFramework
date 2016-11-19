using OracleDb.Core.Initializer;
using OracleDb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDb.Repository
{
    public class RepositoryBaseInitializer<T> : IRepositoryInitializer<T>
        where T : class, IEntity
    {
        private readonly DbContext context;

        public RepositoryBaseInitializer(DbContext context)
        {
            this.context = context;
        }

        public DbSet<T> GetDbSet()
        {
            // Determine the DbSet<T> to initialize the repository with
            return (DbSet<T>)this.context.GetType().GetProperties()?.FirstOrDefault(p => p.PropertyType == typeof(DbSet<T>))?.GetValue(this.context, null);
        }
    }
}
