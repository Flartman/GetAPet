using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public class Breed : Entity<BreedId>
    {
        //ef core
        private Breed(BreedId id) : base(id) { }

        public NotEmptyString Name { get; } = default!;

        public NotEmptyString Description { get; } = default!;
    }
}
