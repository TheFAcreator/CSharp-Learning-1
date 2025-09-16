delegate string DayOfTheWeek();
class DayOfTheWeekRecurring
{
    private static int ind = 1;
    public DayOfTheWeek del = delegate ()
    {
        string output = "";
        switch (ind)
        {
            case 1:
                output = "Monday";
                break;
            case 2:
                output = "Tuesday";
                break;
            case 3:
                output = "Wednesday";
                break;
            case 4:
                output = "Thursday";
                break;
            case 5:
                output = "Friday";
                break;
            case 6:
                output = "Saturday";
                break;
            case 7:
                output = "Sunday";
                break;
        }
        if (ind != 7) ind++;
        else ind = 1;
        return output;
    };
}
class J
{
    static void Main(string[] args)
    {
        DayOfTheWeekRecurring obj = new DayOfTheWeekRecurring();
        for(int i = 0; i <= 9;  i++)
        {
            Console.WriteLine(obj.del());
        }
    }
}