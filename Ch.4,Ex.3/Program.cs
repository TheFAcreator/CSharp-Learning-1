class CharArray
{
    static void Main(string[] args)
    {
        int amount = 10;
        char letter = 'a';
        char[] chars = new char[amount];
        for (int i = 0; i < amount; i++)
        {
            chars[i] = letter;
            letter += (char)2;
        }
        foreach (char c in chars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            Console.Write(chars[i] + " ");
        }
        Console.WriteLine();
    }
}