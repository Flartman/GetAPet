using GetAPet.Domain.Pets;
using GetAPet.Domain.Shared;
namespace GetAPet.Domain.Volunteers
{
    public class Volunteer
    {
        public Guid Id { get; }

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
