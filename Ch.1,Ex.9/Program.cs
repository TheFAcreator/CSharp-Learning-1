class ThreeNumbers
{
    static void Main(string[] args)
    {
        int num, num1, num2;
        Console.Title = "Digits";
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        num1 = num + 1;
        num2 = num - 1;
        Console.WriteLine("Your number is greater than " + num2 + " with 1 and " + num + " - your number - is smaller than " + num1 + " with 1.");
    }
}