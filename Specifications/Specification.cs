using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public virtual IQueryable<T> AddEagerFetching(IQueryable<T> query)
        {
            return query;
        }

        public virtual IQueryable<T> AddPredicates(IQueryable<T> query)
        {
            return query;
        }

        public virtual IQueryable<T> AddSorting(IQueryable<T> query)
        {
            return query;
        }
    }
}
