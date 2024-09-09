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

        private List<SocialNetwork> _socialMedia { get; } = [];

        public IReadOnlyList<PaymentDetails> PaymantDetailsList => _paymantDetailsList;

        private List<PaymentDetails> _paymantDetailsList { get; } = [];

        public IReadOnlyList<Pet> Pets => _pets;

        private List<Pet> _pets { get; } = [];

        public int GetPetsThat(PetStatus petStatus)
        {
            return _pets
                .Where(p => p.Status == petStatus)
                .Count();
        }
    }
}
