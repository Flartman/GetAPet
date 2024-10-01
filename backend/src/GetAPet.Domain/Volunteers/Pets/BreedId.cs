namespace GetAPet.Domain.Volunteers.Pets
{
    public record BreedId
    {
        private BreedId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static BreedId New() => new BreedId(Guid.NewGuid());

        public static BreedId Empty() => new BreedId(Guid.Empty);

        public static BreedId Create(Guid value) => new BreedId(value);
    }
}
