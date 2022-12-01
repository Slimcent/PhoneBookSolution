﻿namespace PhoneBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(int id, string name, string number)
        {
            Id = id;
            Name = name;
            Number = number;
        }
    }
}
