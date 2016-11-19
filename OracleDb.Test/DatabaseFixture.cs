using OracleDb.Context;
using System;

namespace OracleDb.Test
{
    public class DatabaseFixture: IDisposable
    {
        private DevContext DbContext { get; }
    

        public DatabaseFixture()
        {
            this.DbContext = new DevContext();
        }

        public DevContext GetDbContext()
        {
            return this.DbContext;
        }

        public void Dispose()
        {
            this.DbContext.Dispose();
        }
    }
}
