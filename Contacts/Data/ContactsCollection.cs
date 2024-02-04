using Contacts.Models;

namespace Contacts.Data
{
    /// <summary>
    /// Класс телефонная книга
    /// </summary>
    internal class ContactsCollection
    {
        #region Fields
        private List<Contact> _items;
        #endregion Fields

        #region Constructors
        internal ContactsCollection()
        {
            _items = new List<Contact>()
            {
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Метод вывод контакты постранично
        /// </summary>
        internal void PrintContacts()
        {
            Int32 page = 0;

            while (true)
            {
                Console.WriteLine($"Введите номер страницы (1 - {_items.Count / 2})");

                Int32.TryParse(Console.ReadLine(), out page);

                var contacts = GetContacts(page);

                Console.WriteLine();

                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName} | {contact.PhoneNumber} | {contact.Email}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод получает сортированный по имени и фамилии список
        /// и возвращает 2 записи пропуская определённое количество записей.
        /// </summary>
        /// <param name="page">Номер страницы вывода</param>
        /// <returns>Список контактов</returns>
        private IEnumerable<Contact> GetContacts(Int32 page)
        {
            if (page == 0 || page > _items.Count / 2) 
                return Enumerable.Empty<Contact>();

            var sorted = SortContacts();
            var skip = (page - 1) * 2;

            return sorted.Skip(skip).Take(2);
        }

        /// <summary>
        /// Метод сортирует список контактов по имени и фамилии
        /// </summary>
        /// <returns>Отсортированную коллекцию контактов</returns>
        private IEnumerable<Contact> SortContacts() =>
            _items.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
        #endregion Methods
    }
}
