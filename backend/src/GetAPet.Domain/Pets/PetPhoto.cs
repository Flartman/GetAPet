namespace GetAPet.Domain.Pets
{
    public record PetPhoto
    {
        public string PathToFile { get; } = default!;
        public bool IsMain { get; }
    }
}
