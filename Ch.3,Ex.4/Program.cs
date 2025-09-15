using System.Linq.Expressions;

class DaysOfTheWeek
{
    static void Main(string[] args)
    {
        int pick = 0;
        Console.Title = "Day of the week";
        try
        {
            Console.Write("Enter a number between 1 and 7: ");
            pick = int.Parse(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Console.WriteLine("That\'s Monday!");
                    break;
                case 2:
                    Console.WriteLine("That\'s Thuesday!");
                    break;
                case 3:
                    Console.WriteLine("That\'s Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("That\'s Thursday!");
                    break;
                case 5:
                    Console.WriteLine("That\'s Friday!");
                    break;
                case 6:
                    Console.WriteLine("That\'s Saturday!");
                    break;
                case 7:
                    Console.WriteLine("That\'s Sunday!");
                    break;
            }
        }
        catch
        {
            Console.WriteLine("You didn\'t enter a number between 1 and 7.");
        }
        if (pick > 7)
        {
            Console.WriteLine("You didn\'t enter a number between 1 and 7.");
        }
    }
}