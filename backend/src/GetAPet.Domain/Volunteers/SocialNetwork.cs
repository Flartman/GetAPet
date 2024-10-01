
namespace GetAPet.Domain.Volunteers
{
    public record SocialNetwork
    {
        private SocialNetwork(string url, string name)
        {
            Url = url;
            Name = name;
        }

        public string Url { get; } = default!;

        public string Name { get; } = default!;

        public static SocialNetwork Create(string url, string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if(string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));

            return new SocialNetwork(url, name);
        }
    }
}
