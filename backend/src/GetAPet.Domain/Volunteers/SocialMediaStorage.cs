namespace GetAPet.Domain.Volunteers
{
    public record SocialMediaStorage
    {
        public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks;

        private readonly List<SocialNetwork> _socialNetworks = [];
    }
}
