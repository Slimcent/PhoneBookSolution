using PhoneBook.Models;

namespace PhoneBook.Lists
{
    public static class Contacts
    {
        public static List<Contact> GetContacts()
        {
            return new List<Contact> {
                new Contact(1, "Julia", "09076"),
                new Contact(2, "Chi", "08055"),
                new Contact(3, "Doe", "07066")
            };
        }
    }

    public class AllContacts
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        public List<Contact> GetAllContacts()
        {
            contacts = new List<Contact>() 
            { 
                new Contact(1, "Julia", "09076"),
                new Contact(2, "Chi", "08055"),
                new Contact(3, "Doe", "07066")
            };

            return contacts;
        }
    }
}
