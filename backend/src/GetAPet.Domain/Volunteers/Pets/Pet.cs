using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public class Pet(Guid id) : Entity(id)
    {
        public string Name { get; } = default!;

        public string Species { get; } = default!;

        public string Description { get; } = default!;

        public string Breed { get; } = default!;

        public string Coloring { get; } = default!;

        public string HealthInfo { get; } = default!;

        public string Address { get; } = default!;

        public double Weight { get; }

        public double Height { get; }

        public string PhoneNumber { get; } = default!;

        public bool IsNeutered { get; }

        public DateOnly Birthdate { get; }

        public bool IsVaccinated { get; }

        public PetStatus Status { get; }

        public PaymentDetailsStorage? PaymentDetailsStorage { get; }

        public DateOnly CreationDate { get; }

        public PetPhotoAlbum? PhotoAlbum { get; }
    }
}


