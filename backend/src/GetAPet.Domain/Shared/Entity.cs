namespace GetAPet.Domain.Shared
{
    public abstract class Entity
    {
        public Guid Id { get; }

        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}
