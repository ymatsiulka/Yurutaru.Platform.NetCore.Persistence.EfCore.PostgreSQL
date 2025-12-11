using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Specifications.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity, CancellationToken token = default);
        Task AddRange(IEnumerable<T> entities, CancellationToken token = default);
        Task Update(T entity, CancellationToken token = default);
        Task UpdateRange(IEnumerable<T> entities, CancellationToken token = default);
        Task Delete(T entity, CancellationToken token = default);
        Task DeleteRange(IEnumerable<T> entities, CancellationToken token = default);
        Task<int> Count(ISpecification<T> specification, CancellationToken token = default);
        Task<bool> Exists(ISpecification<T> specification, CancellationToken token = default);
        Task<T?> GetOrDefault(object id, CancellationToken token = default);
        Task<T?> GetOrDefault(ISpecification<T> specification, CancellationToken token = default);
        Task<T[]> List(
            ISpecification<T> specification,
            int? skip = null,
            int? take = null,
            CancellationToken token = default);
    }
}