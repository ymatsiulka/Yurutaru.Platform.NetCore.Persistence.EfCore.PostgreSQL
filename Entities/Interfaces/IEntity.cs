namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities.Interfaces
{
    public interface IEntity<TId> : IEquatable<IEntity<TId>> where TId : struct
    {
        TId Id { get; }
    }
}
