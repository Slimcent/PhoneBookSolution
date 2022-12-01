namespace PhoneBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
