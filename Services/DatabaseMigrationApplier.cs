using Microsoft.EntityFrameworkCore;
using Npgsql;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Services.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Services
{
    public sealed class DatabaseMigrationApplier(DbContext context) : IDatabaseMigrationApplier
    {
        public void ApplyMigrations()
        {
            context.Database.Migrate();

            //NOTE: If you are using context.Database.Migrate() to create your enums,
            //you need to instruct Npgsql to reload all types after applying your migrations:
            //https://www.npgsql.org/efcore/mapping/enum.html?tabs=tabid-1
            using (var connection = (NpgsqlConnection)context.Database.GetDbConnection())
            {
                connection.Open();
                connection.ReloadTypes();
            }
        }
    }
}
