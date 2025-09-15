class DayOfTheWeekMonthAndDate
{
    static void Main(string[] args)
    {
        string weekDay, month;
        int date;
        Console.Title = "Calendar, weekday";
        Console.WriteLine("Enter the weekday name");
        weekDay = Console.ReadLine();
        Console.Title = "Calendar, month name";
        Console.WriteLine("Enter the name of the month");
        month = Console.ReadLine();
        Console.Title = "Calendar, date";
        Console.WriteLine("Enter the date");
        date = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"It is the {date} of {month} - {weekDay}.");
    }
}