class ElementSwap
{
    static void ElementsSwap(char[] a) 
    {
        char s;
        for (int i = 0; i < a.Length / 2; i++)
        {
            s = a[i];
            a[i] = a[a.Length - i - 1];
            a[a.Length - i - 1] = s;
        }
    }
    static void Main(string[] args)
    {
        char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        foreach (char c in chars)
        {
            Console.Write(c + " ");
        }
        ElementsSwap(chars);
        Console.WriteLine();
        foreach (char c in chars)
        {
            Console.Write(c + " ");
        }
    }
}