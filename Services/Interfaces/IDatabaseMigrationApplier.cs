namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Services.Interfaces
{
    public interface IDatabaseMigrationApplier
    {
        void ApplyMigrations();
    }
}
