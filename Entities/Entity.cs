using Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities.Interfaces;

namespace Yurutaru.Platform.NetCore.Persistence.EfCore.PostgreSQL.Entities
{
    public abstract class Entity<TId> : IEntity<TId>
        where TId : struct
    {
        public virtual TId Id { get; init; }

        public static bool operator ==(Entity<TId>? first, Entity<TId>? second)
        {
            if (first is null && second is null)
                return true;

            if (first is null || second is null)
                return false;

            var result = first.Equals(second);
            return result;
        }

        public static bool operator !=(Entity<TId>? first, Entity<TId>? second)
        {
            var result = !(first == second);
            return result;
        }

        public bool Equals(IEntity<TId>? other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetType() != other.GetType())
                return false;

            var result = Id.Equals(other.Id);
            return result;
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Entity<TId>;
            var result = Equals(other);

            return result;
        }

        public override int GetHashCode()
        {
            var result = HashCode.Combine(Id);
            return result;
        }
    }
}
