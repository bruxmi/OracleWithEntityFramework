using OracleDb.Context;
using OracleDb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDb.Repository
{
    public class RepositoryDevContextInitializer<T> : RepositoryBaseInitializer<T>
        where T : class, IEntity
    {
        public RepositoryDevContextInitializer(DevContext context)
            : base(context)
        {

        }
    }
}
