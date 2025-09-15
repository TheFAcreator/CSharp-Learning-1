class NameAndSurname
{
    static void Main(string[] args)
    {
        string name, surname;
        Console.Title = "Personal information, name";
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Title = "Personal information, surname";
        Console.Write("Enter you surname: ");
        surname = Console.ReadLine();
        Console.WriteLine($"Hello {name}, your surname is {surname}!" );
    }
}