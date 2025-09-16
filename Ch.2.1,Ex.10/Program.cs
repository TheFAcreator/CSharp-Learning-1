abstract class Base
{
    public abstract int[] MyProperty { get; set; }
    public abstract int this[int index] { get; set; }
    public abstract void MyMethod();
}
interface First
{
    int[] MyProperty { get; set; }
    int this[int index] { get; set; }
    void MyMethod();
}
interface Second
{
    int[] MyProperty { get; set; }
    int this[int index] { get; set; }
    void MyMethod();
}
class Derived : Base, First, Second
{
    private int[] array = new int[10];

    // Implementing abstract members from Base
    public override int[] MyProperty
    {
        get { return array; }
        set { array = value; }
    }
    public override int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    public override void MyMethod()
    {
        Console.WriteLine("Base MyMethod implementation");
    }

    // Explicit interface implementations for First
    int[] First.MyProperty
    {
        get { return array; }
        set { array = value; }
    }
    int First.this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    void First.MyMethod()
    {
        Console.WriteLine("First MyMethod implementation");
    }

    // Explicit interface implementations for Second
    int[] Second.MyProperty
    {
        get { return array; }
        set { array = value; }
    }
    int Second.this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    void Second.MyMethod()
    {
        Console.WriteLine("Second MyMethod implementation");
    }
}

class ExplicitInterfaces
{
    static void Main(string[] args)
    {
        Derived obj = new Derived();
        
        // Using Base class reference
        Base baseRef = obj;
        baseRef.MyProperty[0] = 10;
        Console.WriteLine(baseRef.MyProperty[0]); // Outputs: 10
        baseRef.MyMethod(); // Outputs: Base MyMethod implementation
        
        // Using First interface reference
        First firstRef = obj;
        firstRef.MyProperty[1] = 20;
        Console.WriteLine(firstRef.MyProperty[1]); // Outputs: 20
        firstRef.MyMethod(); // Outputs: First MyMethod implementation
        
        // Using Second interface reference
        Second secondRef = obj;
        secondRef.MyProperty[2] = 30;
        Console.WriteLine(secondRef.MyProperty[2]); // Outputs: 30
        secondRef.MyMethod(); // Outputs: Second MyMethod implementation
    }
}