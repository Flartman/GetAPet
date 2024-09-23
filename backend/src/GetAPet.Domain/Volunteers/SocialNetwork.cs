using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers
{
    public record SocialNetwork
    {
        //ef core
        private SocialNetwork()
        {

        }

        private SocialNetwork(string url, string name)
        {
            URL = url;
            Name = name;
        }

        public string URL { get; } = default!;

        public string Name { get; } = default!;

        public static SocialNetwork Create(string url, string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if(string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));

            return new(url, name);
        }
    }
}
