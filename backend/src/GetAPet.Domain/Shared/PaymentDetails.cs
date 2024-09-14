namespace GetAPet.Domain.Shared
{
    public record PaymentDetails
    {
        public string Name { get; } = default!;

        public string Description { get; } = default!;
    }
}
