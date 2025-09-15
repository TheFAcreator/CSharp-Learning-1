class Age
{
    static void Main(string[] args)
    {
        int birthYear, age;
        Console.Title = "Verification, birth year";
        Console.WriteLine("Please enter you year of birth below to verify your age");
        birthYear = int.Parse(Console.ReadLine());
        age = 2024 - birthYear;
        if (age < 18)
        {
            Console.WriteLine("Sorry, you are not old enough!");
        } else
        {
            Console.WriteLine("Welcome, you are old enough!");
        }
    }
}