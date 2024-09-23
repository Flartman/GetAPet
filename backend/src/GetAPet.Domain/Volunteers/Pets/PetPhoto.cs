using GetAPet.Domain.Shared;

namespace GetAPet.Domain.Volunteers.Pets
{
    public record PetPhoto
    {
        private PetPhoto(string pathToFile, bool isMain)
        {
            PathToFile = pathToFile;
            IsMain = isMain;
        }
        public string PathToFile { get; } = default!;
        public bool IsMain { get; }

        public static PetPhoto Create(string pathToFile, bool isMain)
        {
            //валидация

            return new PetPhoto(pathToFile, isMain);
        }
    }
}
