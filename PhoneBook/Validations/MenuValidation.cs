namespace PhoneBook.Validations
{
    public static class MenuValidation
    {
        public static void InvalidPrompt(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid selection {field}, please Choose the right Option");
            Console.ResetColor();
        }
    }
}
