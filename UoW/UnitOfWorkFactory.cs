using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW
{
    public sealed class UnitOfWorkFactory(IServiceProvider provider) : IUnitOfWorkFactory
    {
        public IUnitOfWork BeginTransaction()
        {
            var dbContext = provider.GetRequiredService<DbContext>();
            var result = new UnitOfWork(dbContext);
            return result;
        }
    }
}