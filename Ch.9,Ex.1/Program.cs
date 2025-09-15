class AlphabetConfined
{
    private char symb;
    Random rnd = new Random();
    public AlphabetConfined()
    {
        Symbol = (char)rnd.Next('A', 'Z' + 1);
    }
    public char Symbol
    {
        get
        {
            return symb;
        }
        set
        {
            if (value < 'A')
            {
                symb = 'A';
            }
            else if (value > 'Z')
            {
                symb = 'Z';
            }
            else
            {
                symb = value;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        AlphabetConfined obj = new AlphabetConfined();
        Console.WriteLine(obj.Symbol);
        obj.Symbol = 'a';
        Console.WriteLine(obj.Symbol);
        obj.Symbol = '*';
        Console.WriteLine(obj.Symbol);
        obj.Symbol = 'G';
        Console.WriteLine(obj.Symbol);
    }
}