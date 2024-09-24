using GetAPet.Domain.Shared;
using System.Xml.Linq;

namespace GetAPet.Domain.Volunteers
{
    public record FullName
    {
        //ef core
        private FullName() { }
        private FullName(string surname, string name, string patronymic)
        {
            Surname = new(surname);
            Name = new(name);
            Patronymic = new(patronymic);
        }

        public NotEmptyString Surname { get; } = default!;

        public NotEmptyString Name { get; } = default!;

        public NotEmptyString? Patronymic { get; }

        public static FullName Create(string surname, string name, string patronymic = "")
        {
            return new FullName(surname, name, patronymic);
        }
    }
}
