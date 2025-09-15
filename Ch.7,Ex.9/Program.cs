class BreakString
{
    string txt;
    char breaker;
    public BreakString(string txt, char breaker)
    {
        this.txt = txt;
        this.breaker = breaker;
    }
    public string[] BreakText()
    {
        string[] newWords;
        newWords = txt.Split(breaker);
        return newWords;
    }
    public override string ToString()
    {
        string show = "";
        show += "string field: " + txt;
        show += "\nchar field: " + breaker;
        show += "\n";
        foreach (string word in BreakText())
        {
            show += word + "\n";
        }
        return show;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BreakString obj = new BreakString("I have: a cat, a dog, a girrafe and a zebra.", ',');
        string[] words = obj.BreakText();
        Console.WriteLine(obj);
    }
}