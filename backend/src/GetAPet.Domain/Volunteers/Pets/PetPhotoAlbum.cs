namespace GetAPet.Domain.Volunteers.Pets
{
    public record PetPhotoAlbum
    {
        public IReadOnlyList<PetPhoto> Photos => _photos;

        private readonly List<PetPhoto> _photos = [];
    }
}
