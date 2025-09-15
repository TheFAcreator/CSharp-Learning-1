class Base
{
    protected string txt;
    public virtual void Set(string txt)
    {
        this.txt = txt;
    }
    public virtual void Set()
    {
        txt = "auto generated... ah";
    }
    public Base(string txt)
    {
        this.txt = txt;
    }
    public int Length
    {
        get
        {
            return txt.Length;
        }
    }
    public int this[char a]
    {
        get
        {
            return txt.IndexOf(a);
        }
    }
    public override string ToString()
    {
        return txt;
    }
}
class ManyStringOperations : Base
{
    public int num;
    public override void Set()
    {
        base.Set();
        num = 5673;
    }
    public override void Set(string txt)
    {
        base.Set(txt);
        num = 2947;
    }
    public void Set(int num)
    {
        base.Set();
        this.num = num;
    }
    public void Set(string txt, int num)
    {
        base.Set(txt);
        this.num = num;
    }
    public ManyStringOperations(int num, string txt) : base(txt)
    {
        this.num = num;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base("sfdg");
        Console.WriteLine(obj);
        obj.Set();
        Console.WriteLine(obj);
        obj.Set("ddjh");
        Console.WriteLine(obj);
        ManyStringOperations obj2 = new ManyStringOperations(87, " wte");
        Console.WriteLine(obj2.num);
        Console.WriteLine(obj2);
        obj2.Set();
        Console.WriteLine(obj2.num);
        Console.WriteLine(obj2);
        obj2.Set(76);
        Console.WriteLine(obj2.num);
        Console.WriteLine(obj2);
        obj2.Set("3sdjw9j");
        Console.WriteLine(obj2.num);
        Console.WriteLine(obj2);
        obj2.Set("shfgu", 745);
        Console.WriteLine(obj2.num);
        Console.WriteLine(obj2);
        Console.WriteLine(obj.Length);
        Console.WriteLine(obj2.Length);
        Console.WriteLine(obj['j']);
    }
}