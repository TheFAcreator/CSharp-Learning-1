delegate int Inter(int j);
class ComplexMechanism
{
    static Inter Method(Inter del, Inter del2)
    {
        return delegate(int n)
        {
            return del(del2(n));
        };
    }
    static void Main(string[] args)
    {
        Inter del = new Inter(delegate(int i)
        {
            return i * 3;
        });
        Inter del2 = Method(del, delegate (int i)
        {
            return i + 2;
        });
        Inter del3 = Method(i => i - 5, del);
        Console.WriteLine(del2(3));
        Console.WriteLine(del3(3));
    }
}