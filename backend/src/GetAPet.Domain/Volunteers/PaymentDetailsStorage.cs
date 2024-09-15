namespace GetAPet.Domain.Volunteers
{
    public record PaymentDetailsStorage
    {
        public IReadOnlyList<PaymentDetails> PaymantDetailsList => _paymantDetailsList;

        private readonly List<PaymentDetails> _paymantDetailsList = [];
    }
}