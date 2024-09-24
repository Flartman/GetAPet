using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers
{
    public record PaymentDetails
    {
        private PaymentDetails(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; } = default!;

        public string Description { get; } = default!;

        public static PaymentDetails Create(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException(nameof(description));

            return new PaymentDetails(name, description);
        }
    }
}