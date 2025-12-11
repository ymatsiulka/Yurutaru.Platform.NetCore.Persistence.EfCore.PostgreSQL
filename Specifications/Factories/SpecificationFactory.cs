using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Factories.Interfaces;
using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Factories
{
    public class SpecificationFactory : ISpecificationFactory
    {
        public ISpecification<T> AllSpecification<T>()
        {
            var result = new AllSpecification<T>();
            return result;
        }

        public ISpecification<TEntity> ByIdSpecification<TEntity, TId>(TId id)
            where TEntity : Entity<TId>
            where TId : struct
        {
            var result = new ByIdSpecification<TEntity, TId>(id);
            return result;
        }
    }
}