namespace GetAPet.Domain.Volunteers.Pets
{
    public record Address
    {
        public string Country { get; } = default!;

        public string Region { get; } = default!;

        public string City { get; } = default!;

        public string Street { get; } = default!;

        public int HouseNumber { get; }

        public int EntranceNumber { get; }

        public int FloorNumber { get; }

        public int ApartmentNumber { get; }
    }
}
