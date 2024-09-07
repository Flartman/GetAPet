using System.Drawing;

namespace GetAPet.Domain.Pet
{
    public class Pet
    {
        public Guid Id { get; }

        public Guid VolunteerId { get; }

        public string Name { get; } = default!;

        public string Species { get; } = default!;

        public string Description { get; } = default!;

        public string Breed { get; } = default!;

        public Color Coloring { get; } = default!;

        public string HealthInfo { get; } = default!;

        public string Address { get; } = default!;

        public double Weight { get; }

        public double Height { get; }

        public string PhoneNumber { get; } = default!;

        public bool IsNeutered { get; }

        public DateOnly Birthdate { get; }

        public bool IsVaccinated { get; }

        public PetStatus Status { get; }

        public List<Property> Properties { get; } = [];

        public DateOnly CreationDate { get; }
    }
}
