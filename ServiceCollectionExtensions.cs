using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Repositories;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Repositories.Interfaces;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Services;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Services.Interfaces;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Settings;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Factories;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Factories.Interfaces;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase<TContext>(
            this IServiceCollection serviceCollection,
            IConfigurationSection databaseSettings)
            where TContext : DbContext
        {
            ArgumentNullException.ThrowIfNull(serviceCollection);

            serviceCollection.AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();
            serviceCollection.AddScoped<ISpecificationFactory, SpecificationFactory>();
            serviceCollection.AddScoped<IDatabaseMigrationApplier, DatabaseMigrationApplier>();
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(NpgsqlRepository<>));

            serviceCollection.AddDbContext<DbContext, TContext>();

            serviceCollection.Configure<DatabaseSettings>(databaseSettings);

            return serviceCollection;
        }
    }
}