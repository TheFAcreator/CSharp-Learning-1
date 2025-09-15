class TextFieldCasts
{
    public string txt;
    public static implicit operator int (TextFieldCasts obj)
    {
        return obj.txt.Length;
    }
    public static implicit operator char(TextFieldCasts obj)
    {
        return obj.txt[0];
    }
    public static explicit operator TextFieldCasts(int num)
    {
        TextFieldCasts newObj = new TextFieldCasts();
        newObj.txt = "";
        // the line above is not required
        for (int i = 0; i < num; i++)
        {
            newObj.txt += "A";
        }
        return newObj;
    }
}
class Program
{
    static void Main(string[] args)
    {
        TextFieldCasts obj = new TextFieldCasts();
        obj.txt = "ABCDEFG";
        int num = obj;
        char symb = obj;
        TextFieldCasts obj2 = (TextFieldCasts)5;
        Console.WriteLine(obj.txt);
        Console.WriteLine(num);
        Console.WriteLine(symb);
        Console.WriteLine(obj2.txt);
    }
}