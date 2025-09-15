class Between5And10
{
    static void Main(string[] args)
    {
        int num;
        Console.Title = "Between 5 and 10";
        Console.WriteLine("Enter a whole number:");
        num = int.Parse(Console.ReadLine());
        if (num > 5 && num < 10)
        {
            Console.WriteLine("Your number is between 5 and 10");
        }
        else
        {
            Console.WriteLine("Your number is not between 5 and 10");
        }
    }
}