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

        public List<SocialNetwork> SocialMedia { get; } = [];

        public List<PaymentDetails> PaymantDetailsList { get; } = [];

        private List<Pet> Pets { get; } = [];

        public List<Pet> GetPetsThat(PetStatus petStatus)
        {
            return Pets
                .Where(p => p.Status == petStatus)
                .ToList();
        }
    }
}
