class ExampleClass
{
    public int Property { get; set; }
    public ExampleClass(int value)
    {
        Property = value;
    }
}
class GenericPropertyWithGenericBackingField<T>
{
    private T _value;
    public T Value
    {
        get => _value;
        set => _value = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var instance = new GenericPropertyWithGenericBackingField<int>();
        instance.Value = 42;
        Console.WriteLine(instance.Value); // Output: 42
        
        var stringInstance = new GenericPropertyWithGenericBackingField<string>();
        stringInstance.Value = "Hello, World!";
        Console.WriteLine(stringInstance.Value); // Output: Hello, World!
        
        var obj = new ExampleClass(32);
        Console.WriteLine(obj.Property); // Output: 32
    }
}