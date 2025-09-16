public struct MyStruct
{
    public char symb;
}
public class EachSymbolIsAStruct
{
    static MyStruct[] ToStructs(string str)
    {
        MyStruct[] result = new MyStruct[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            result[i].symb = str[i];
        }
        return result;
    }
    static string ToText(MyStruct[] arr)
    {
        string res = string.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i].symb;
        }
        return res;
    }
    static void Main()
    {
        MyStruct[] arr = ToStructs("Hello, World!");
        Console.WriteLine(arr[7].symb);
        Console.WriteLine(arr[3].symb);
        Console.WriteLine(arr[0].symb);
        string txt = ToText(arr);
        Console.WriteLine(txt);
    }
}