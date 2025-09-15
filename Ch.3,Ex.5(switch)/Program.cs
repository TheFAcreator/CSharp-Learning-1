class DayOfTheWeekSwitch
{
    static void Main(string[] args)
    {
        string decision;
        Console.Title = "Day of the week";
        Console.WriteLine("Enter a name of a day of the week");
        decision = Console.ReadLine();
        switch(decision)
        {
            case "Monday":
                Console.WriteLine("1");
                break;
            case "Thuesday":
                Console.WriteLine("2");
                break;
            case "Wednesday":
                Console.WriteLine("3");
                break;
            case "Thursday":
                Console.WriteLine("4");
                break;
            case "Friday":
                Console.WriteLine("5");
                break;
            case "Saturday":
                Console.WriteLine("6");
                break;
            case "Sunday":
                Console.WriteLine("7");
                break;
            default:
                Console.WriteLine("You didn\'t enter a valid name. (It must start with a capital letter)");
                break;
        }
    }
}