using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public record Address
    {
        private Address(string country, string region, string city)
        {
            Country= country;
            Region = region;
            City = city;
        }

        public string Country { get; } = default!;

        public string Region { get; } = default!;

        public string City { get; } = default!;

        public static Address Create(string country, string region, string city) => new (country, region, city);
    }
}
