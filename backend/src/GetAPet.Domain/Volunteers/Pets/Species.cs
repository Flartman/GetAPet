using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public class Species : Entity<SpeciesId>
    {
        //ef core
        private Species(SpeciesId id) : base(id) { }

        public NotEmptyString Name { get; } = default!;

        public NotEmptyString Description { get; } = default!;

        public IReadOnlyList<Breed> Breeds => _breeds;

        private readonly List<Breed> _breeds = [];
    }
}
