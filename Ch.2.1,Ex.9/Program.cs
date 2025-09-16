abstract class CharArrayOperations
{
    protected char[] chars;
    public CharArrayOperations(string str)
    {
        chars = str.ToCharArray();
    }
    public char Get(int i)
    {
        return chars[i];
    }
    public abstract void Set(int i, char c);
}
interface First
{
    void Set(string str);
    char this[int i]
    {
        get; set;
    }
}
class Derived : CharArrayOperations, First
{
    public Derived(string str) : base(str) { }
    public override void Set(int i, char c)
    {
        chars[i] = c;
    }
    public void Set(string str)
    {
        chars = str.ToCharArray();
    }
    public char this[int i]
    {
        get
        {
            return chars[i];
        }
        set
        {
            chars[i] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string txt = "My dog is too beefy!";
        Derived obj = new Derived(txt);
        for(int i = 0; i < txt.Length; i++)
        {
            Console.Write(obj[i]);
            if (i != txt.Length - 1) Console.Write(" | ");
        }
        Console.WriteLine();
        txt = "My goose is gone!";
        obj.Set(txt);
        for(int i = 0; i < txt.Length; i++)
        {
            Console.Write(obj.Get(i));
            if (i != txt.Length - 1) Console.Write(" | ");
        }
        Console.WriteLine();
        obj[6] = 'z';
        obj.Set(3, 'x');
        Console.WriteLine(obj[6]);
        for (int i = 0; i < txt.Length; i++)
        {
            Console.Write(obj[i]);
            if (i != txt.Length - 1) Console.Write(" | ");
        }
        Console.WriteLine();
    }
}