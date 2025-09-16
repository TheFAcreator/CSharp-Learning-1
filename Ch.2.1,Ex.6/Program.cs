interface First
{
    int this[char symb]
    {
        get;
    }
}
interface Second
{
    char this[int num]
    {
        get;
    }
}
class CodeTableOfSymbols : First, Second
{
    public int this[char symb]
    {
        get
        {
            return symb;
        }
    }
    public char this[int num]
    {
        get
        {
            return (char)num;
        }
    }
    static void Main(string[] args)
    {
        CodeTableOfSymbols obj = new CodeTableOfSymbols();
        Console.WriteLine(obj['G']);
        Console.WriteLine(obj[73]);
        First obj2 = new CodeTableOfSymbols();
        Console.WriteLine(obj2['A']);
        Second obj3 = new CodeTableOfSymbols();
        Console.WriteLine(obj3['B']);
        Console.WriteLine(obj[68]);
    }
}