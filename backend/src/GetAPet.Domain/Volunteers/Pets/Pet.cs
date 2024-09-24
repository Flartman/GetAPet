using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public class Pet : Entity<PetId>
    {
        //ef core
        private Pet(PetId id) : base(id)
        {

        }

        public NotEmptyString Name { get; } = default!;

        public NotEmptyString Species { get; } = default!;

        public NotEmptyString Description { get; } = default!;

        public NotEmptyString Breed { get; } = default!;

        public NotEmptyString Coloring { get; } = default!;

        public NotEmptyString HealthInfo { get; } = default!;

        public Address Address { get; } = default!;

        public double Weight { get; }

        public double Height { get; }

        public NotEmptyString PhoneNumber { get; } = default!;

        public bool IsNeutered { get; }

        public DateOnly Birthdate { get; }

        public bool IsVaccinated { get; }

        public PetStatus Status { get; }

        public PaymentDetailsStorage? PaymentDetailsStorage { get; }

        public DateOnly CreationDate { get; }

        public PetPhotoAlbum? PhotoAlbum { get; }
    }
}


