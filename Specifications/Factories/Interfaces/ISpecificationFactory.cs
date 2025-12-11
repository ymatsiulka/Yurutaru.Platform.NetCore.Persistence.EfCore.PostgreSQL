using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Factories.Interfaces
{
    public interface ISpecificationFactory
    {
        ISpecification<T> AllSpecification<T>();
        ISpecification<TEntity> ByIdSpecification<TEntity, TId>(TId id)
            where TEntity : Entity<TId>
            where TId : struct;
    }
}