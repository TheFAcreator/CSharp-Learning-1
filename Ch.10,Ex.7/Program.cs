class Base
{
    public string txt;
    public virtual CopyingAnObject Copying()
    {
        CopyingAnObject copy = new CopyingAnObject();
        return copy; // alternative: return new CopyingAnObject();
    }
}
class CopyingAnObject : Base
{
    public char symb;
    public override CopyingAnObject Copying()
    {
        CopyingAnObject obj = this;
        return obj; // alternative: return this;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base();
        obj.txt = "textt";
        CopyingAnObject obj2 = obj.Copying();
        obj2.symb = 'g';
        Console.WriteLine(obj2.symb);
        CopyingAnObject obj3 = new CopyingAnObject();
        CopyingAnObject obj4 = obj3.Copying();
        obj4.txt = "sjs";
        obj4.symb = 'f';
        Console.WriteLine(obj4.symb);
        Console.WriteLine(obj4.txt);
    }
}