delegate int CharFinder(char symb, string txt);
class TextOperations
{
    static void Main(string[] args)
    {
        static int Matches(char s, string t)
        {
            int count = t.Count(c => c == s);
            return count;
        }
        static int FirstMatch(char s, string t)
        {
            int count = t.IndexOf(s);
            return count;
        }
        CharFinder del = new CharFinder(Matches);
        Console.WriteLine(del('l', "Hello world!"));
        del = FirstMatch;
        Console.WriteLine(del('l', "Hello world!"));
        Console.WriteLine(del('y', "Hello world!"));
    }
}