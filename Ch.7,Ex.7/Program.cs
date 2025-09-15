class SubstringImitation
{
    static string SubstrImitation(string text, int index, int symbCount)
    {
        string result = "";
        int symbCount1 = index + symbCount;
        while (index < symbCount1)
        {
            result += text[index];
            index++;
        }
        return result;
    }
    static void Main(string[] args)
    {
        string txt = "My favourite book is Harry Potter.";
        string str = SubstrImitation(txt, 21, 12);
        Console.WriteLine(str);
    }
}