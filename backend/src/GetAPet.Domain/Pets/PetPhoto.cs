namespace GetAPet.Domain.Pets
{
    public record PetPhoto
    {
        public string PathToFile { get; private set; } = default!;
        public bool IsMain { get; private set; }
    }
}
