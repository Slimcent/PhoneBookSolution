using PhoneBook.Models;
using PhoneBook.Operations;
using PhoneBook.Validations;
using System.Text;

namespace PhoneBook
{
    public static class Application
    {
        public static void Menu()
        {
            Console.Clear();
            var menu = new StringBuilder();
            menu.AppendLine("Phone book application\n");
            menu.AppendLine("Please, select the Operation to perform\n");
            menu.Append("Press 1 to Add contact\n");
            menu.Append("Press 2 to Display contact by number\n");
            menu.Append("Press 3 to View all contacts\n");
            menu.Append("Press 4 to Search contacts by name\n");
            menu.Append("Press 11 to Log out/Exit\n");

            Console.WriteLine(menu.ToString());
            string selection = Console.ReadLine();

            while (selection != "1" && selection != "2" && selection != "3" && selection != "11")
            {
                Console.ResetColor();
                MenuValidation.InvalidPrompt(selection);
                selection = Console.ReadLine();
            }

            PhoneBookOperations operations = new PhoneBookOperations();

            while (true)
            {
                switch (selection)
                {
                    case "1":
                        operations.AddContact();

                        break;
                    case "2":
                        Console.WriteLine("Enter number");
                        string number = Console.ReadLine();

                        operations.DisplayContact(number);

                        break;
                    case "3":
                        GetContacts.GetAllContacts();
                        //operations.DisplayAllContacts();

                        break;
                    case "4":
                        Console.WriteLine("Enter search term");
                        string searchTerm = Console.ReadLine();

                        operations.DisplayMatchingContacts(searchTerm);

                        break;
                    case "11":
                        Exit("11");
                        break;
                    default:
                        Console.WriteLine("Invalid selection made, please, choose the right option");
                        break;
                }

                Console.WriteLine("Select operation");
                selection = Console.ReadLine();
            }
        }

        public static bool Exit(string num)
        {
            return string.Equals(num, "11", StringComparison.OrdinalIgnoreCase);
        }
    }
}
