namespace OracleDb.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Core.Entities;
    using System.IO;

    public partial class DevContext : DbContext
    {
        public DevContext()
            : base("name=DevContext")
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DEVUSER");
            modelBuilder
              .Properties()
              .Where(p => p.PropertyType == typeof(string))
              .Configure(p => p.IsUnicode(false));
        }
    }
}
