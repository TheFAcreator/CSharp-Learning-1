class StaticPrivateInt
{
    private static int num = 0;
    public static void ShowAndIncrease()
    {
        Console.WriteLine(num);
        num++;
    }
}
class Program
{
    static void Main(string[] args)
    {
        StaticPrivateInt.ShowAndIncrease();
        StaticPrivateInt.ShowAndIncrease();
    }
}