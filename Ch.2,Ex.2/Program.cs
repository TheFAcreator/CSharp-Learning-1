class MeaninglessCriteriaCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 5 == 2 && num % 7 == 1)
        {
            Console.WriteLine("Your number follows both of the criteria.");
        }
        else
        {
            Console.WriteLine("Your number doesn't follow both of the criteria.");
        }
    }
}