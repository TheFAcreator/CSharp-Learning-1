class AddingAndExtractingChars
{
    public char symb;

    public static string operator +(AddingAndExtractingChars obj, AddingAndExtractingChars obj2)
    {
        string txt = string.Empty;
        txt += obj.symb;
        txt += obj2.symb;
        return txt;
    }
    public static int operator -(AddingAndExtractingChars obj, AddingAndExtractingChars obj2)
    {
        return Math.Abs(obj.symb - obj2.symb);
    }

    public static implicit operator AddingAndExtractingChars(string txt)
    {
        AddingAndExtractingChars obj = new();

        char symb = txt[0];
        char symb2 = txt[1];
        int num = symb + symb2;
        obj.symb = Convert.ToChar(num);

        return obj;
    }
    public static implicit operator AddingAndExtractingChars(int num)
    {
        AddingAndExtractingChars obj = new();
        try
        {
            obj.symb = Convert.ToChar(num);
        }
        catch
        {
            Console.WriteLine("Error occurred.");
        }
        return obj;
    }
}
class Program
{
    static void Main(string[] args)
    {
        AddingAndExtractingChars obj = new();
        obj.symb = 'c';

        AddingAndExtractingChars obj2 = new();
        obj2.symb = 'a';

        Console.WriteLine(obj + obj2); // ca
        Console.WriteLine(obj - obj2); // 2 (99 - 97)

        AddingAndExtractingChars obj3 = new();
        obj3.symb = 'b';
        obj3 += obj;
        Console.WriteLine(obj3.symb); // Å (99 + 97)

        AddingAndExtractingChars obj4 = new();
        obj4.symb = 'd';
        obj4 -= obj;
        Console.WriteLine(obj4.symb); // ☺ (100 - 99)
    }
}