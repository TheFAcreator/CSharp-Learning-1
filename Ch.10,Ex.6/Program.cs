class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public virtual void Show()
    {
        Console.WriteLine("Base class. txt field: " + txt);
    }
}
class Derived : Base
{
    protected int num;
    public Derived(int num, string str) : base(str)
    {
        this.num = num;
    }
    public override void Show()
    {
        Console.WriteLine("Derived class. num field: " + num + "; txt field: " + txt);
    }
}
class CheckingDerivedClassesWithBaseObject : Base
{
    protected char symb;
    public CheckingDerivedClassesWithBaseObject(char symb, string str) : base(str)
    {
        this.symb = symb;
    }
    public override void Show()
    {
        Console.WriteLine("CheckingDerivedClassesWithBaseObject class. symb field: " + symb + "; txt field: " + txt);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base("this is a text");
        Derived obj2 = new Derived(23, "this is a new text");
        CheckingDerivedClassesWithBaseObject obj3 = new CheckingDerivedClassesWithBaseObject('t', "this is a new text again");
        obj.Show();
        obj2.Show();
        obj3.Show();
        obj = obj2;
        obj.Show();
        obj = obj3;
        obj.Show();
        Base obj4 = new Derived(45, "f");
        obj4.Show();
    }
}