using System.Security.Cryptography;

class CharsBetween
{
    public char start, end;
    public void FromStartToEnd()
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i + " ");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        CharsBetween obj = new CharsBetween();
        obj.start = 'R';
        obj.end = 'Z';
        obj.FromStartToEnd();
    }
}