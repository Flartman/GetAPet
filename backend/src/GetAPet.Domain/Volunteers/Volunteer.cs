<<<<<<< Updated upstream
﻿using GetAPet.Domain.Pets;
using GetAPet.Domain.Shared;
using System.Collections.Generic;
=======
﻿using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers.Pets;
>>>>>>> Stashed changes
namespace GetAPet.Domain.Volunteers
{
    public class Volunteer(Guid id) : Entity(id)
    {
        public string FullName { get; } = default!;

        public string Email { get; } = default!;

        public string Description { get; } = default!;

        public int ExperienceInYears { get; }

        public string PhoneNumber { get; } = default!;

        public IReadOnlyList<SocialNetwork> SocialMedia => _socialMedia;

        private readonly List<SocialNetwork> _socialMedia = [];

        public IReadOnlyList<PaymentDetails> PaymantDetailsList => _paymantDetailsList;

        private readonly List<PaymentDetails> _paymantDetailsList = [];

        public IReadOnlyList<Pet> Pets => _pets;

        private readonly List<Pet> _pets  = [];

        public int GetCountPetsThat(PetStatus petStatus)
        {
            return _pets
                .Where(p => p.Status == petStatus)
                .Count();
        }
    }
}
