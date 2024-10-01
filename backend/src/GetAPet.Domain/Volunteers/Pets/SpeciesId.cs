namespace GetAPet.Domain.Volunteers.Pets
{
    public record SpeciesId
    {
        private SpeciesId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static SpeciesId New() => new SpeciesId(Guid.NewGuid());

        public static SpeciesId Empty() => new SpeciesId(Guid.Empty);

        public static SpeciesId Create(Guid value) => new SpeciesId(value);
    }
}
