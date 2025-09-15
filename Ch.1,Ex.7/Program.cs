class DateOfBirthCalculation
{
    static void Main(string[] args)
    {
        int age, dateOfdBirth;
        Console.Title = "Personal information, age";
        Console.WriteLine("Please enter your age below:");
        age = Int32.Parse(Console.ReadLine());
        dateOfdBirth = 2024 - age;
        Console.WriteLine("Your date of birth is " + dateOfdBirth + ".");
    }
}