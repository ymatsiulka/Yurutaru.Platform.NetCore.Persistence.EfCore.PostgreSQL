namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
        Task Rollback();
    }
}