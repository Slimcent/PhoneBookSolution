using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class DisplayContactDetails
    {
        public static void DisplayAllContactDetails(Contact contact)
        {
            Console.WriteLine($"Id : {contact.Id} | Name : {contact.Name} | Phone Number {contact.Number}");
        }
    }
}
