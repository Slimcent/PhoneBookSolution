using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class DisplayContactsDetails
    {
        public static void DisplayAllContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails.DisplayAllContactDetails(contact);
            }
        }
    }
}
