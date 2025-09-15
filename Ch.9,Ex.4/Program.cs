class UsingOctalNumbersAndUints
{
    private uint num;
    private string txt;
    public UsingOctalNumbersAndUints(uint num)
    {
        this.num = num;
        string str = num.ToString();
        txt = Convert.ToString(Convert.ToInt32(str, 8));
    }
    public uint SetUint
    {
        set
        {
            num = value;
            txt = Convert.ToString(Convert.ToInt32(num.ToString(), 8));
        }
    }
    public string GetUint
    {
        get
        {
            return txt;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        UsingOctalNumbersAndUints obj = new UsingOctalNumbersAndUints(12);
        Console.WriteLine(obj.GetUint);
        obj.SetUint = 13;
        Console.WriteLine(obj.GetUint);
    }
}