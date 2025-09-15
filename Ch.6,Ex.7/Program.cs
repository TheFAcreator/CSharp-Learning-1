class CharStringFields
{
    public char symb;
    public string txt;
    public void AssignValue(char a)
    {
        symb = a;
    }
    public void AssignValue(string a)
    {
        txt = a;
    }
    public void AssignValue(char[] a)
    {
        if (a.Length == 1)
        {
            symb = a[0];
        }
        else
        {
            txt = "";
            for (int i = 0; i < a.Length; i++)
            {
                txt += a[i];
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        char[] chars = { 'u' };
        char[] chars2 = { 'g', 'o', 'o', 's', 'e' };
        CharStringFields obj = new CharStringFields();
        obj.AssignValue('f');
        Console.WriteLine(obj.symb);
        obj.AssignValue("duck");
        Console.WriteLine(obj.txt);
        obj.AssignValue(chars);
        Console.WriteLine(obj.symb);
        obj.AssignValue(chars2);
        Console.WriteLine(obj.txt);
    }
}