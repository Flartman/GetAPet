namespace GetAPet.Domain.Shared
{
    public abstract class Entity<TId>
    {
        protected Entity(TId id)
        {
            Id = id;
        }

        public TId Id { get; }
    }
}
