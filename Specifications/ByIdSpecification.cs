using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications
{
    public class ByIdSpecification<TEntity, TId>(TId id) : Specification<TEntity>
        where TEntity : Entity<TId>
        where TId : struct
    {
        public override IQueryable<TEntity> AddPredicates(IQueryable<TEntity> query)
        {
            var result = query.Where(x => x.Id.Equals(id));
            return result;
        }
    }
}