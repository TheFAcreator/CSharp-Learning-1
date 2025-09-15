class ElementIndexSwap
{
    static void Main(string[] args)
    {
        int k = 1;
        char s;
        char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        foreach (char c in chars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < chars.Length / 2; i++)
        {
            s = chars[i];
            chars[i] = chars[chars.Length - k];
            chars[chars.Length - k] = s;
            k++;
        }
        foreach (char c in chars)
        {
            Console.Write(c + " ");
        }
    }
}