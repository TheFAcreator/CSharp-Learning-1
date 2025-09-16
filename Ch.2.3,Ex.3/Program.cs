public struct MyStruct
{
    public MyStruct(string str)
    {
        chars = str.ToCharArray();
    }
    public MyStruct(int n, char a)
    {
        chars = new char[n];
        for (int i = 0; i < n; i++) chars[i] = a;
    }
    char[] chars;
    public char this[int i]
    {
        get { return chars[i]; }
        set { chars[i] = value; }
    }
    public void ReverseSymbs()
    {
        chars = chars.Reverse().ToArray();
    }
    public override string ToString()
    {
        string res = "";
        for(int i = 0; i < chars.Length; i++) res += $"{chars[i]}\t";
        res += "\n";
        for (int i = 0; i < chars.Length; i++) res += $"{(int)chars[i]}\t";
        return res;
    }
}
public class CharArrayOperations
{
    static void Main(string[] args)
    {
       MyStruct exm = new("Some text");
        Console.WriteLine(exm);
        Console.WriteLine();
        exm.ReverseSymbs();
        Console.WriteLine(exm);
        Console.WriteLine();
        MyStruct exm2 = new(5, 'a');
        Console.WriteLine(exm2);
        Console.WriteLine();
        exm2[4] = 'b';
        Console.WriteLine(exm2);
        Console.WriteLine();
        Console.WriteLine(exm2[3]);
        Console.WriteLine(exm[2]);
    }
}