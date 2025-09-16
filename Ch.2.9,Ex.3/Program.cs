class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter birth date (yyyy-mm-dd): ");
        string? input = Console.ReadLine();

        int wholeYears = 0;
        int wholeMonths = 0;
        int wholeDays = 0;

        if (DateTime.TryParse(input, out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            
            TimeSpan age = today - birthDate;

            wholeYears = (int)(age.TotalDays / 365);
            wholeMonths = (int)(age.TotalDays / 30);
            wholeDays = (int)(age.TotalHours / 24) - 1;

            Console.WriteLine($"Whole years: {wholeYears}, whole months: {wholeMonths}, whole days: {wholeDays}.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format.");
            Console.ReadLine();
            Main(args); // Restart program
        }
    }
}