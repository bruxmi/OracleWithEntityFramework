using OracleDb.Context;
using OracleDb.Core.Extensions;
using System;
using System.Text;

namespace OracleDb.Test
{
    public class DatabaseFixtureWithCleanUpEntities: IDisposable
    {
        private DevContext DbContext { get; }


        public DatabaseFixtureWithCleanUpEntities()
        {
            this.DbContext = new DevContext();
        }

        public DevContext GetDbContext()
        {
            return this.DbContext;
        }

        public void Dispose()
        {
            DeleteEntities();
            this.DbContext.Dispose();
        }

        private void DeleteEntities()
        {
            var assembly = typeof(DevContext).Assembly;
            var builder = new StringBuilder();
            builder.Append(assembly.GetManifestResourceText(DbConstants.CONTEXT_CLEANUP_RESOURCE));
            var sql = builder.ToString();
            DbContext.Database.ExecuteSqlCommand(sql);
        }
    }
}
