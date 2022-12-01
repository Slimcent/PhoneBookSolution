using PhoneBook.Models;

namespace PhoneBook.Lists
{
    public static class Users
    {
        public static List<User> GetUsers()
        {
            return new List<User> {
                new User(1, "Julia", "17"),
                new User(2, "Chi", "y6"),
                new User(3, "Doe", "007")
            };
        }
    }
}
