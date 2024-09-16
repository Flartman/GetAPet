namespace GetAPet.Domain.Volunteers.Pets
{
    public record PetPhotoAlbum
    {
        public IReadOnlyList<PetPhoto> Photos = [];
    }
}
