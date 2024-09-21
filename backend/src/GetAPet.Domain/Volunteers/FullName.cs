namespace GetAPet.Domain.Volunteers
{
    public record FullName
    {
        public string Surname { get; } = default!;

        public string Name { get; } = default!;

        public string Patronymic { get; } = default!;
    }
}
