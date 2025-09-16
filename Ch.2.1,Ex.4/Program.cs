abstract class TwoIntFieldsAddition // Ch.1.2,Ex.4
{
    protected int num;
    protected int num2;
    public TwoIntFieldsAddition(int i, int k)
    {
        num = i;
        num2 = k;
    }
    public abstract int this[int i]
    {
        get;
    }
}
interface First
{
    int Method(int i);
}
class Program : TwoIntFieldsAddition, First
{
    Program(int i, int j) : base(i, j) { }
    public override int this[int i]
    {
        get
        {
            if (i % 2 == 0) return num;
            else return num2;
        }
    }
    public int Method(int i)
    {
        return (num + num2) * i;
    }
    static void Main(string[] args)
    {
        Program obj = new Program(5, 8);
        First obj2 = new Program(5, 9);
        Console.WriteLine(obj2.Method(2));
        Console.WriteLine(obj[2]);
        Console.WriteLine(obj[1]);
        Console.WriteLine(obj.Method(3));
    }
}