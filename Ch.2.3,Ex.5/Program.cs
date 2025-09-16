public struct MyStruct
{
    public MyStruct(int num1, int num2, int num3)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.num3 = num3;
    }
    public MyStruct(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
        num3 = 0;
    }
    public MyStruct(int num1)
    {
        this.num1 = num1;
        num2 = 0;
        num3 = 1;
    }
    private int num1;
    private int num2;
    private int num3;
    public int Max
    {
        set
        {
            int max = Math.Max(num1, Math.Max(num2, num3));
            if(max == num1) num1 = value;
            else if (max == num2) num2 = value;
            else num3 = value;
        }
        get
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }
    }
    public int Min
    {
        set
        {
            int min = Math.Min(num1, Math.Min(num2, num3));
            if (min == num1) num1 = value;
            else if (min == num2) num2 = value;
            else num3 = value;
        }
        get
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }
    }
}
class MaxMinInts
{
    static void Main(string[] args)
    {
        MyStruct myStruct1 = new MyStruct(1, 2, 3);
        MyStruct myStruct2 = new MyStruct(4, 5);
        MyStruct myStruct3 = new MyStruct(6);
        Console.WriteLine("Max of myStruct1: " + myStruct1.Max);
        Console.WriteLine("Min of myStruct1: " + myStruct1.Min);
        Console.WriteLine("Max of myStruct2: " + myStruct2.Max);
        Console.WriteLine("Min of myStruct2: " + myStruct2.Min);
        Console.WriteLine("Max of myStruct3: " + myStruct3.Max);
        Console.WriteLine("Min of myStruct3: " + myStruct3.Min);
        myStruct1.Max = 10;
        myStruct1.Min = 0;
        myStruct2.Max = 20;
        myStruct2.Min = 5;
        myStruct3.Max = 30;
        myStruct3.Min = 10;
        Console.WriteLine("After setting new max and min values:");
        Console.WriteLine("Max of myStruct1: " + myStruct1.Max);
        Console.WriteLine("Min of myStruct1: " + myStruct1.Min);
        Console.WriteLine("Max of myStruct2: " + myStruct2.Max);
        Console.WriteLine("Min of myStruct2: " + myStruct2.Min);
        Console.WriteLine("Max of myStruct3: " + myStruct3.Max);
        Console.WriteLine("Min of myStruct3: " + myStruct3.Min);
    }
}