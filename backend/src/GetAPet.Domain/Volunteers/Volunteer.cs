using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers.Pets;
namespace GetAPet.Domain.Volunteers
{
    public class Volunteer(VolunteerId id) : Entity<VolunteerId>(id)
    {
        public FullName? FullName { get; }

        public string Email { get; } = default!;

        public string Description { get; } = default!;

        public int ExperienceInYears { get; }

        public string PhoneNumber { get; } = default!;

        public SocialMediaStorage? SocialMedia {  get; }

        public PaymentDetailsStorage? PaymentDetailsStorage { get; }

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
