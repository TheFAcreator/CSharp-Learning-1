enum WeekDays
{
    
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
class WeekDayOperations
{
    static WeekDays GetDay(int n)
    {
        if (n > 0 && n <= 7)
        {
            return (WeekDays)n;
        }
        int day = n % 7;
        if (day == 0)
        {
            return WeekDays.Sunday;
        }
        else
        {
            return (WeekDays)day;
        }
    }
    static int MinDaysBetween(int n1, int n2)
    {
        WeekDays day1 = GetDay(n1);
        WeekDays day2 = GetDay(n2);
        int day1Value = (int)day1;
        int day2Value = (int)day2;
        return Math.Min(Math.Abs(day1Value - day2Value), Math.Abs(Math.Max(day1Value, day2Value) - Math.Min(day1Value, day2Value) - 7));
    }
    static void Main(string[] args)
    {
        Console.WriteLine(GetDay(6));
        Console.WriteLine(GetDay(8));
        Console.WriteLine(GetDay(15));
        Console.WriteLine(GetDay(0));
        Console.WriteLine(MinDaysBetween(4, 7));
        Console.WriteLine(MinDaysBetween(7, 4));
        Console.WriteLine(MinDaysBetween(8, 15));
        Console.WriteLine(MinDaysBetween(0, 0));
        Console.WriteLine(MinDaysBetween(1, 8));
        Console.WriteLine(MinDaysBetween(1, 7));
    }
}