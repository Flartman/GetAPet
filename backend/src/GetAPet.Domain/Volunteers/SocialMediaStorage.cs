namespace GetAPet.Domain.Volunteers
{
    public record SocialMediaStorage
    {
        public IReadOnlyList<SocialNetwork> SocialNetworks = [];
    }
}
