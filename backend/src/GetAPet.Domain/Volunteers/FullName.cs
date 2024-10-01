using GetAPet.Domain.Shared;
using System.Xml.Linq;

namespace GetAPet.Domain.Volunteers
{
    public record FullName
    {
        private FullName(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public string Surname { get; } = default!;

        public string Name { get; } = default!;

        public string? Patronymic { get; }

        public static FullName Create(string surname, string name, string patronymic = "")
        {
            if (surname is null || name is null)
                throw new ArgumentNullException();

            return new FullName(surname, name, patronymic);
        }
    }
}
