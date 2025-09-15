class PrivateIntValue
{
    private int num;
    public void AssignValue(int value)
    {
        if (value > 100)
        {
            num = 100;
        }
        else
        {
            num = value;
        }
    }
    public void AssignValue()
    {
        num = 0;
    }
    public PrivateIntValue(int value)
    {
        if (value > 100)
        {
            num = 100;
        }
        else
        {
            num = value;
        }
    }
    public PrivateIntValue()
    {
        num = 0;
    }
    public void Show()
    {
        Console.WriteLine(num);
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        PrivateIntValue obj = new PrivateIntValue(45);
        obj.Show();
        PrivateIntValue obj2 = new PrivateIntValue();
        obj2.Show();
        obj.AssignValue(378);
        obj.Show();
        obj.AssignValue();
        obj.Show();
    }
}