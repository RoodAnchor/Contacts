namespace Contacts.Models
{
    internal class Contact
    {
        public Contact(
            String firstName,
            String lastName,
            Int64 phoneNumber,
            String email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int64 PhoneNumber { get; set; }
        public String Email { get; set; }
    }
}
