using PhoneBook.Lists;
using PhoneBook.Models;

namespace PhoneBook
{
    public class PhoneBookOperations
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"{contact.Id} {contact.Name} {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach(Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact()
        {
            Console.WriteLine("Enter name");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter number");
            string userNumber = Console.ReadLine();

            int newId = GetLastId();

            Contact newContact = new(newId, userName, userNumber);

            contacts.Add(newContact);

            Console.WriteLine("Contact created successfully");
        }

        public void RemoveContact(Contact request)
        {
            contacts.Remove(request);
        }

        public void DisplayContact(string number)
        {
            Contact contact = contacts.FirstOrDefault(x => x.Number == number);
            if (contact != null)
            {
                DisplayContactDetails(contact);
            }

            Console.WriteLine("Contact not found");
        }

        public void DisplayAllContacts()
        {
            DisplayContactsDetails(contacts);
        }

        public void DisplayMatchingContacts(string searchTerm)
        {
            IEnumerable<Contact> matchingContact = contacts.Where(c => c.Name.Contains(searchTerm)).ToList();

            DisplayContactsDetails((List<Contact>)matchingContact);
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
        
        public int GetLastId()
        {
            List<Contact> allContacts = AllContacts();
            Contact newId = allContacts.LastOrDefault();

            int id;

            if (newId == null)
            {
                id = 1;
            }
            else
            {
                id = newId.Id + 1;
            }

            return id;
        }

        public List<Contact> AllContacts()
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
