class MonthAndItsDayCount
{
    static void Main(string[] args)
    {
        string month;
        int dayCount;
        Console.Title = "Month";
        Console.WriteLine("Enter a month name below");
        month = Console.ReadLine();
        Console.Title = "Day Count";
        Console.WriteLine("Enter the count of the days in the month entered below");
        dayCount = Int32.Parse(Console.ReadLine());
        Console.WriteLine(month +  " has " +  dayCount + " days.");
    }
}