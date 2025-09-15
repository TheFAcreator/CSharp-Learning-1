
class Base
{
    public int num;
    public void Set(int x)
    {
        num = x;
    }
    public Base(int x)
    {
        num = x;
    }
    public override string ToString()
    {
        string str = "Base class. num field: " + num;
        return str;
    }
}
class Derived : Base
{
    public char symb;
    public void Set(int x, char z)
    {
        Set(x);
        symb = z;
    }
    public Derived(char z, int x) : base(x)
    {
        symb = z;
    }
    public override string ToString()
    {
        string str = "Derived class. num field: " + num + "; symb fied: " + symb;
        return str;
    }
}
class ThreeChainedClasses : Derived
{
    public string txt;
    public void Set(int x, char y, string z)
    {
        txt = z;
        Set(x, y);
    }
    public ThreeChainedClasses(string z, int x, char y) : base(y, x)
    {
        txt = z;
    }
    public override string ToString()
    {
        string str = "ThreeChainedClasses. num field: " + num + "; symb fied: " + symb + "; txt field: " + txt;
        return str;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base(12);
        Console.WriteLine(A);
        A.Set(14);
        Console.WriteLine(A);
        Derived B = new Derived('f', 16);
        Console.WriteLine(B);
        B.Set(18, 't');
        Console.WriteLine(B);
        ThreeChainedClasses C = new ThreeChainedClasses("this is a cat", 20, 'o');
        Console.WriteLine(C);
        C.Set(22, 's', "this is a dog");
        Console.WriteLine(C);
    }
}