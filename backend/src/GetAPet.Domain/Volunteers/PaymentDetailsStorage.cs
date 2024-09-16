namespace GetAPet.Domain.Volunteers
{
    public record PaymentDetailsStorage
    {
        public IReadOnlyList<PaymentDetails> PaymantDetailsList = [];
    }
}