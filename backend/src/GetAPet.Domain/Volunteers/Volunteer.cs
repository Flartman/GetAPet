using GetAPet.Domain.Shared;
using GetAPet.Domain.Volunteers.Pets;
namespace GetAPet.Domain.Volunteers
{
    public class Volunteer : Entity<VolunteerId>
    {
        //ef core
        private Volunteer(VolunteerId id) : base(id)
        {

        }

        public FullName FullName { get; } = default!;

        public NotEmptyString Email { get; } = default!;

        public NotEmptyString Description { get; } = default!;

        public int ExperienceInYears { get; }

        public NotEmptyString PhoneNumber { get; } = default!;

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
