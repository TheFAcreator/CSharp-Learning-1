
class Base
{
    protected string txt;
    public virtual string GetOrSetTxt
    {
        get
        {
            return txt;
        }
        set
        {
            txt = value;
        }
    }
    public override string ToString()
    {
        string str = "Base class, txt field: " + txt;
        return str;
    }
}
class AssigningValuesToTwoStrings : Base
{
    string txt2;
    public override string GetOrSetTxt
    {
        get
        {
            return txt + " " + txt2;
        }
        set
        {
            if (value.Contains(" "))
            {
                string[] strs = value.Split(" ", 2);
                txt = strs[0];
                txt2 = strs[1];
            }
            else
            {
                txt = value;
            }
        }
    }
    public override string ToString()
    {
        string str = "Base class, txt field: " + txt + "; AssigningValuesToTwoStrings class, txt2 field: " + txt2;
        return str;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base();
        obj.GetOrSetTxt = "Hello there!";
        Console.WriteLine(obj.GetOrSetTxt);
        Console.WriteLine(obj.ToString());
        AssigningValuesToTwoStrings obj2 = new AssigningValuesToTwoStrings();
        obj2.GetOrSetTxt = "Hi there, buddy";
        Console.WriteLine(obj2.GetOrSetTxt);
        Console.WriteLine(obj2.ToString());
        obj2.GetOrSetTxt = "Ohhhhhhhhh!";
        Console.WriteLine(obj2.GetOrSetTxt);
        Console.WriteLine(obj2.ToString());
    }
}