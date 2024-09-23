using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public record Address
    {
        private Address(string country, string region, string city)
        {
            Country= new NotEmptyString(country);
            Region = new NotEmptyString(region);
            City = new NotEmptyString(city);
        }

        public NotEmptyString Country { get; } = default!;

        public NotEmptyString Region { get; } = default!;

        public NotEmptyString City { get; } = default!;

        public static Address Create(string country, string region, string city)
        {
            return new Address(country, region, city);
        }

    }
}
