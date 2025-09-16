struct MiniStruct
{
    int value;
    
    public static MainStruct operator +(MiniStruct a, MiniStruct b)
    {
        return new MainStruct(a.value, b.value);
    }
    
    public MiniStruct(int v)
    {
        value = v;
    }

    public int GetValue()
    {
        return value;
    }
}
struct MainStruct
{
    int value1;
    int value2;

    public MiniStruct[] BreakDown(MainStruct main)
    {
        return new MiniStruct[] { new MiniStruct(main.value1), new MiniStruct(main.value2) };
    }

    public MainStruct(int v1, int v2)
    {
        value1 = v1;
        value2 = v2;
    }

    public (int, int) GetValues()
    {
        return (value1, value2);
    }
}

class StructMergingAndBreakingDown
{
    static void Main(string[] args)
    {
        MiniStruct mini1 = new MiniStruct(5);
        Console.WriteLine(mini1.GetValue());
        
        MiniStruct mini2 = new MiniStruct(10);
        Console.WriteLine(mini2.GetValue());
        
        MainStruct main = mini1 + mini2;
        var (v1, v2) = main.GetValues();
        Console.WriteLine($"MainStruct values: {v1}, {v2}");
        
        MiniStruct[] minis = main.BreakDown(main);
        Console.WriteLine($"Broken down MiniStruct values: {minis[0].GetValue()}, {minis[1].GetValue()}");
    }
}