class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public override string ToString()
    {
        string str = "Base class. Txt field: " + txt;
        return str;
    }
}
class TwoProtectedStrings : Base
{
    protected string str;
    public TwoProtectedStrings(string str) : base(str)
    {
        this.str = str;
    }
    public TwoProtectedStrings(string txt, string str) : base(txt)
    {
        this.str = str;
    }
    public override string ToString()
    {
        string txt = "Derived class. Str field: " + str + "; Txt field: " + base.txt;
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("this is a text");
        Console.WriteLine(A);
        TwoProtectedStrings B = new TwoProtectedStrings("this is an equal text");
        Console.WriteLine(B);
        TwoProtectedStrings C = new TwoProtectedStrings("this is a txt", "this is a str");
        Console.WriteLine(C);
    }
}