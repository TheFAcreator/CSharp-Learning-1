class UsingBinaryMoving
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number - the program will return the the third bit starting from the end of the binary representation of your number.");
        byte num = byte.Parse(Console.ReadLine());
        num >>= 3;
        int bit = num % 2; // or num & 1
        Console.WriteLine(bit);
    }
}