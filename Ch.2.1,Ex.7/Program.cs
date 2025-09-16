interface First
{
    int Property1
    {
        get;
        set;
    }
    void Method();
}
interface Second
{
    string Property2
    {
        get;
        set;
    }
    void Method();
}
class SameInterfaces : First, Second
{
    public int Property1
    {
        get; set;
    }
    public string Property2
    {
        get; set;
    }
    public void Method()
    {
        Console.WriteLine(Property1);
        Console.WriteLine(((Second)this).Property2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SameInterfaces obj = new SameInterfaces();
        obj.Property1 = 431;
        obj.Property2 = "ok, let's do this!";
        obj.Method();
    }
}