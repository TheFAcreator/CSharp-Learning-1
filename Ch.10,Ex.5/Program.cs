class Base
{
    public char symb;

    public Base(char s)
    {
        symb = s;
    }
    public Base(Base obj)
    {
        symb = obj.symb;
    }
    public Base()
    {

    }
}
class Derived : Base
{
    public string txt;
    public Derived(char s, string t) : base(s)
    {
        txt = t;
    }
    public Derived(Derived obj)
    {
        symb = obj.symb;
        txt = obj.txt;
    }
    public Derived()
    {

    }
}
class ThreeClassChain : Derived
{
    public int num;
    public ThreeClassChain(char s, string t, int n) : base(s, t)
    {
        num = n;
    }
    public ThreeClassChain(ThreeClassChain obj)
    {
        symb = obj.symb;
        txt = obj.txt;
        num = obj.num;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base('d');
        Derived obj2 = new Derived('g', "vb");
        ThreeClassChain obj3 = new ThreeClassChain('p', "f y", 89);
        Console.WriteLine(obj.symb);
        Console.WriteLine(obj2.symb + " " + obj2.txt);
        Console.WriteLine(obj3.symb + " " + obj3.txt + " " + obj3.num);
        Base obj4 = new Base(obj);
        Derived obj5 = new Derived(obj2);
        ThreeClassChain obj6 = new ThreeClassChain(obj3);
        Console.WriteLine(obj4.symb);
        Console.WriteLine(obj5.symb + " " + obj5.txt);
        Console.WriteLine(obj6.symb + " " + obj6.txt + " " + obj6.num);
    }
}