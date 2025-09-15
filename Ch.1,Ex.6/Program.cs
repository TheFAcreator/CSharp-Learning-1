using System.Globalization;

class NameAndDateOfBirth
{
    static void Main(string[] args)
    {
        string name;
        int birthDate;
        Console.Title = "Personal info, name";
        Console.WriteLine("Enter your name below");
        name = Console.ReadLine();
        Console.Title = "Personal info, birth date";
        Console.WriteLine("Enter you birth date below");
        birthDate = 2024-Int32.Parse(Console.ReadLine());
        Console.WriteLine("Hi, " + name + " you are " + birthDate + " years old!");
    }
}