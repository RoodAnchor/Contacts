using Contacts.Data;

namespace Contacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactsCollection contacts = new ContactsCollection();

            contacts.PrintContacts();
        }
    }
}