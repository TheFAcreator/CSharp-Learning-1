public struct MyStruct
{
    public int num;
    public int num2;
    public static MyStruct CreateStruct(int[] ints)
    {
        int num = ints.Max();
        int index = Array.IndexOf(ints, num);
        return new MyStruct
        {
            num = num,
            num2 = index
        };
    }
}
public class StructCreator
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4, 5 };
        MyStruct myStruct = MyStruct.CreateStruct(ints);
        Console.WriteLine($"Max: {myStruct.num}, Index: {myStruct.num2}");
    }
}