using PhoneBook.Lists;
using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class GetContacts
    {
        public static void GetAllContacts()
        {
            List<Contact> allContacts = Contacts.GetContacts();

            DisplayContactsDetails.DisplayAllContactsDetails(allContacts);
        }
    }
}
