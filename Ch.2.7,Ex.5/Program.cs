abstract class ObjectChainingBase
{
    public ObjectChainingBase? Next { get; set; }
    public abstract Type GetInstanceType();
    public abstract object GetInstance();

    public void ExposeChainFromHere()
    {
        Console.WriteLine($"Exposing chain from {this.GetInstanceType().Name} - {this.GetInstance()}");

        var next = this.Next;
        while (next != null)
        {
            Console.WriteLine(" |\n" + next.GetInstanceType().Name + " - " + next.GetInstance());
            next = next.Next;
        }
    }
}

class ObjectChaining<T> : ObjectChainingBase where T : class // restriction is optional, can be removed if not needed
{
    private readonly T _instance;
    public T Instance => _instance;

    public override object GetInstance() => _instance;
    public override Type GetInstanceType() => typeof(T);


    public ObjectChaining(T instance)
    {
        _instance = instance;
    }
}
class ExampleClass
{
    public string Name { get; set; }
    public int Value { get; set; }
    public ExampleClass()
    {
        Name = "Example";
        Value = 42;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj1 = new ObjectChaining<string>("Hello, World!");
        var exampleObj = new ExampleClass();
        var obj2 = new ObjectChaining<ExampleClass>(exampleObj);
        var obj3 = new ObjectChaining<string>("End of Chain");

        // Build the chain
        obj1.Next = obj2;
        obj2.Next = obj3;
        //obj3.Next = obj1; - this will make the chain circular

        Console.WriteLine(obj1.Instance); // Hello, World!
        Console.WriteLine(obj2.Instance.Name); // Example
        Console.WriteLine(obj2.Instance.Value); // 42
        Console.WriteLine(obj3.Instance); // End of Chain
        Console.WriteLine();

        // Chain print
        obj1.ExposeChainFromHere();
    }
}