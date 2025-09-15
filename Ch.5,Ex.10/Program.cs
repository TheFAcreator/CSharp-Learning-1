class AddingSymbolsAfterAText
{
    static string AddSymbs(string txt, params char[] symbs)
    {
        for (int i = 0; i < symbs.Length; i++)
        {
            txt += symbs[i];
        }
        return txt;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(AddSymbs("Have you ever ", 'k', 'i', 's', 's', 'e', 'd', ' ', 'a', ' ', 'c', 'a', 't', '?'));
        Console.WriteLine(AddSymbs("I am not "));
    }
}