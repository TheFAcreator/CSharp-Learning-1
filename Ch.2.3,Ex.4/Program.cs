public struct MyStruct
{
    int[] ints;
    public MyStruct(int len)
    {
        Random rnd = new Random();
        ints = new int[len];
        for (int i = 0; i < len; i++)
        {
            ints[i] = rnd.Next(-100, 100);
        }
    }
    public int MaxElement()
    {
        return ints.Max();
    }
    public int MinElement()
    {
        return ints.Min();
    }
    public double AverageValue()
    {
        return ints.Average();
    }
}
public class IntArrayOperations
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the length of the array:");
            int len = int.Parse(Console.ReadLine());
            MyStruct myStruct = new MyStruct(len);
            Console.WriteLine($"Max: {myStruct.MaxElement()}");
            Console.WriteLine($"Min: {myStruct.MinElement()}");
            Console.WriteLine($"Average: {myStruct.AverageValue()}");
        }
    }
}