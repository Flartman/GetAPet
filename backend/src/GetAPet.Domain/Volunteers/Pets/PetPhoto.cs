namespace GetAPet.Domain.Volunteers.Pets
{
    public record PetPhoto
    {
        public string PathToFile { get; } = default!;
        public bool IsMain { get; }
    }
}
