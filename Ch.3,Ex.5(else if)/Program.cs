class DayOfWeekElseif
{
    static void Main(string[] args)
    {
        string weekDay;
        int number;
        Console.Title = "Day of week";
        Console.Write("Enter a name of a day of week(starting with a capital letter): ");
        weekDay = Console.ReadLine();
        if (weekDay == "Monday")
        {
            Console.WriteLine("1st day of week");
        }
        else if(weekDay == "Thuesday")
        {
            Console.WriteLine("2nd day of week");
        }
        else if(weekDay == "Wednesday")
        {
            Console.WriteLine("3rd day of week.");
        }
        else if(weekDay == "Thursday")
        {
            Console.WriteLine("4th day of week.");
        }
        else if (weekDay == "Friday")
        {
            Console.WriteLine("5th day of week.");
        }
        else if (weekDay == "Saturday")
        {
            Console.WriteLine("6th day of week.");
        }
        else if (weekDay == "Sunday")
        {
            Console.WriteLine("7th day of week.");
        }
        else
        {
            Console.WriteLine("You didn\'t enter a valid name of a day of week.");
        }
    }
}