class NullSummary
{
    static void Main(string[] args)
    {
        double num, sum = 0;
        try
        {
        Loop:
            Console.Title = "Numbers";
            Console.Write("Enter a number: ");
            num = double.Parse(Console.ReadLine());
            sum += num;
            goto Loop;
        }
        catch
        {
            Console.WriteLine("Your final summary is: " + sum + "");
        }
    }
}