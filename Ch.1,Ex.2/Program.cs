using Microsoft.VisualBasic;
class InputInfoInConsole
{
    static void Main(string[] args)
    {
        string name;
        int age;
        Console.Title = "Personal info, name";
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.Title = "Personal info, age";
        Console.WriteLine("What is your age?");
        age = Int32.Parse(Console.ReadLine());
        Console.Title = "Completed";
        Console.WriteLine("Hi " + name + ", you are " + age + " years old!");
    }
}