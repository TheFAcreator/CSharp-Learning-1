public class InversionOfStringWithPointers
{
    static unsafe void Main(string[] args)
    {
        string str = new string("Hello, World!");
        string copy = str;
        fixed (char* p = str)
        {
            for(int i = 0; i < str.Length / 2; i++)
            {
                (p[str.Length - i - 1], p[i]) = (p[i], p[str.Length - i - 1]);
            }
        }
        Console.WriteLine(str);
    }
}