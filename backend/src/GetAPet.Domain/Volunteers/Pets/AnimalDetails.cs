using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAPet.Domain.Volunteers.Pets
{
    public record AnimalDetails
    {
        private AnimalDetails(SpeciesId speciesId, BreedId breedId)
        {
            SpeciesId = speciesId;
            BreedId = breedId;
        }

        public SpeciesId SpeciesId { get; }

        public BreedId BreedId { get; }

        public static AnimalDetails Create(SpeciesId speciesId, BreedId breedId)
            => new(speciesId, breedId);

    }
}
