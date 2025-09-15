class CharFieldUsage
{
    private char symb;
    public void AssignValue(char value)
    {
        symb = value;
    }
    public int CharCode()
    {
        return symb;
    }
    public void CharValueAndCode()
    {
        Console.WriteLine(symb + " " + (int)symb);
    }
}
class Program
{
    static void Main(string[] args)
    {
        CharFieldUsage obj = new CharFieldUsage();
        obj.AssignValue('e');
        int symb1 = obj.CharCode();
        Console.WriteLine(symb1);
        obj.CharValueAndCode();
    }
}