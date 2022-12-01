using PhoneBook.Models;

namespace PhoneBook
{
    public class PhoneBookOperations
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"{contact.Name} {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach(Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact request)
        {
            contacts.Add(request);
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


    }
}
