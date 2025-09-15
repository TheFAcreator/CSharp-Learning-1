class Base
{
    public int[] ints;
    public Base(int[] ints)
    {
        this.ints = ints;
    }
    public override string ToString()
    {
        string result = "";
        foreach (int i in ints)
        {
            result += i;
            result += ", ";
        }
        return result;
    }
}
class CopyingArrays : Base
{
    char[] chars;
    public CopyingArrays(char[] chars, int[] ints) : base(ints)
    {
        this.chars = chars;
    }
    public override string ToString()
    {
        string result = string.Empty;
        foreach (char c in chars)
        {
            result += c;
            result += ", ";
        }
        result += "\n";
        foreach (int i in ints)
        {
            result += i;
            result += ", ";
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 4, 234, 33582 };
        Base obj = new Base(ints);
        Console.WriteLine(obj);
        char[] chars = { 'a', 'b', 'c', 'd', 'j', 'd' };
        int[] ints2 = { 58, 46747, 23 };
        CopyingArrays obj2 = new CopyingArrays(chars, ints2);
        Console.WriteLine(obj2);
        CopyingArrays obj3 = new CopyingArrays(chars, ints);
        Console.WriteLine(obj3);
    }
}