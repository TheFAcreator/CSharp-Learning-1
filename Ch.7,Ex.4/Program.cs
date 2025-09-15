class DoubleConstructor
{
    char symb;
    int num;
    public DoubleConstructor(char a, int b)
    {
        symb = a;
        num = b;
        Console.WriteLine(symb  + " " + num);
    }
    public DoubleConstructor(double a)
    {
        symb = (char)a;
        num = (int)a;
        Console.WriteLine(symb + " " + num);
    }
}
class Program
{
    static void Main(string[] args)
    {
        DoubleConstructor obj = new DoubleConstructor('d', 35);
        DoubleConstructor obj2 = new DoubleConstructor(66.4569);
    }
}