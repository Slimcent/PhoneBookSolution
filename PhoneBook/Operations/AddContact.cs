using PhoneBook.Lists;
using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class AddContact
    {
        public static void AddAContact()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter number");
            string number = Console.ReadLine();

            CreateContact(name, number);

            Console.WriteLine($"New contact Name {name} and Number {number} created successfully");
        }

        static void CreateContact(string name, string number)
        {
            int newId = GetLastId();

            List<Contact> allContacts = Contacts.GetContacts();

            Contact newContact = new(newId, name, number);
            allContacts.Add(newContact);
        }

        public static int GetLastId()
        {
            List<Contact> allContacts = Contacts.GetContacts();
            int newId = allContacts.LastOrDefault().Id + 1;

            return newId;
        }
    }
}
