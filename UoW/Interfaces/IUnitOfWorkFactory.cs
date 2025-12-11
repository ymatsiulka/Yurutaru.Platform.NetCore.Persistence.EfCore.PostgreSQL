namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.UoW.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork BeginTransaction();
    }
}