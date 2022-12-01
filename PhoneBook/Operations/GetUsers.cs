using PhoneBook.Lists;
using PhoneBook.Models;

namespace PhoneBook.Operations
{
    public static class GetUsers
    {
        public static void GetAllUsers()
        {
            List<User> allUsers = Users.GetUsers();

            foreach(User user in allUsers)
            {
                Console.WriteLine($"{user.Id} {user.Name}");
            }
        }
    }
}
