namespace GetAPet.Domain.Volunteers
{
    public record PaymentDetails
    {
        public string Name { get; } = default!;

        public string Description { get; } = default!;
    }
}