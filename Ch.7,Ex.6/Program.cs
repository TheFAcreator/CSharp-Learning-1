class TwoIntValues
{
    private int min;
    private int max;
    public void AssignValues(int a)
    {
        min = a;
        max = a;
    }
    public void AssignValues(int a, int b)
    {
        if (a < b)
        {
            min = a;
            max = b;
        }
        else if (a == b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }
    }
    public TwoIntValues(int a, int b)
    {
        if (a < b)
        {
            min = a;
            max = b;
        }
        else if (a == b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }
    }
    public void Show()
    {
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}
class Program
{
    static void Main(string[] args)
    {
        TwoIntValues obj = new TwoIntValues(67, 89);
        obj.Show();
        Console.WriteLine();
        obj.AssignValues(34);
        obj.Show();
        Console.WriteLine();
        obj.AssignValues(57, 3);
        obj.Show();
    }
}