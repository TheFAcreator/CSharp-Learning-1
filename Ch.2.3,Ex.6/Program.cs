public struct MyStruct
{
    public int num1;
    public int num2;
    public static MyStruct operator +(MyStruct a, MyStruct b)
    {
        return new MyStruct { num1 = a.num1 + b.num1, num2 = a.num2 + b.num2 };
    }
    public static MyStruct operator -(MyStruct a, MyStruct b)
    {
        return new MyStruct { num1 = a.num1 - b.num1, num2 = a.num2 - b.num2 };
    }
    public static MyStruct operator *(MyStruct a, MyStruct b)
    {
        return new MyStruct { num1 = a.num1 * b.num1, num2 = a.num2 * b.num2 };
    }
    public static int operator +(MyStruct a)
    {
        return Math.Max(a.num1, a.num2);
    }
    public static int operator -(MyStruct a)
    {
        return Math.Min(a.num1, a.num2);
    }
}
public class OperatorMethodsForTwoIntFields
{
    static void Main(string[] args)
    {
        MyStruct exm = new MyStruct();
        MyStruct exm2 = new MyStruct();
        exm.num1 = 5;
        exm.num2 = 10;
        exm2.num1 = 3;
        exm2.num2 = 4;
        MyStruct result = exm + exm2;
        Console.WriteLine($"Addition: {result.num1}, {result.num2}");
        result = exm - exm2;
        Console.WriteLine($"Subtraction: {result.num1}, {result.num2}");
        result = exm * exm2;
        Console.WriteLine($"Multiplication: {result.num1}, {result.num2}");
        int max = +exm;
        Console.WriteLine($"Max 1: {max}");
        int min = -exm;
        Console.WriteLine($"Min 1: {min}");
        int max2 = +exm2;
        Console.WriteLine($"Max 2: {max2}");
        int min2 = -exm2;
        Console.WriteLine($"Min 2: {min2}");
    }
}