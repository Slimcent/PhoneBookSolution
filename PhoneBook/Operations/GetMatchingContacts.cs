using PhoneBook.Lists;
using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class GetMatchingContacts
    {
        public static void GetAllMatchingContacts(string searchTerm)
        {
            List<Contact> allContacts = Contacts.GetContacts();

            IEnumerable<Contact> matchingContacts = allContacts.Where(c => c.Name.Contains(searchTerm)).ToList();
                        
            foreach (Contact contact in matchingContacts)
            {
                //Console.WriteLine($"{contact.Id} {contact.Name} {contact.Number}");
                DisplayContactDetails.DisplayAllContactDetails(contact);
            }
        }
    }
}
