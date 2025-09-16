interface First
{
    string Property
    {
        get;
    }
}
interface Second
{
    string Property
    {
        get;
    }
}
class SameStringProperties : First, Second
{
    public string Property
    {
        get
        {
            return "Implicit implementation";
        }
    }
    string First.Property
    {
        get
        {
            return "Explicit implementation of interface First";
        }
    }
    string Second.Property
    {
        get
        {
            return "Explicit implementation of interface Second";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        SameStringProperties obj = new SameStringProperties();
        Console.WriteLine(obj.Property);
        First obj2 = new SameStringProperties();
        Console.WriteLine(obj2.Property);
        Second obj3 = new SameStringProperties();
        Console.WriteLine(obj3.Property);
    }
}