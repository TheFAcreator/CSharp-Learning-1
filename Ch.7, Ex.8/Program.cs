class AddSubstring
{
    public string str;
    public AddSubstring(string newValue)
    {
        str = newValue;
    }
    public void Add(string substring, int index)
    {
        str = str.Insert(index, substring);
        str = str.Insert(index, " ");
    }
    public override string ToString()
    {
        return str;
    }
}
class Program
{
    static void Main(string[] args)
    {
        AddSubstring obj = new AddSubstring("I loathe cats.");
        Console.WriteLine(obj);
        obj.Add("don\'t", 1);
        Console.WriteLine(obj);
    }
}