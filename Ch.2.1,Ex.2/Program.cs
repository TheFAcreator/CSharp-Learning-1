abstract class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public abstract int Length
    {
        get;
    }
    public abstract int this[int index]
    {
        get;
    }
    public abstract void Set(string str);
    public abstract void Get();
}
class StringFieldActions : Base
{
    public StringFieldActions(string txt) : base(txt) { }
    public override int Length
    {
        get
        {
            return txt.Length;
        }
    }
    public override int this[int index]
    {
        get
        {
            return txt[index];
        }
    }
    public override void Set(string str)
    {
        txt = str;
    }
    public override void Get()
    {
        Console.WriteLine(txt);
    }
}
class program
{
    static void Main(string[] args)
    {
        Base obj = new StringFieldActions("Let's go buddies!");
        for(int i = 0; i < obj.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj.Get();
        obj.Set("Let's go seamen!");
        obj.Get();
    }
}