namespace GetAPet.Domain.Volunteers
{
    public record SocialNetwork
    {
        public string URL { get; } = default!;

        public string Name { get; } = default!;
    }
}
