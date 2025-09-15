
class OverloadingTrueAndFalse
{
    int num;
    public char symb;
    public OverloadingTrueAndFalse(int num, char symb)
    {
        this.num = num;
        this.symb = symb;
    }
    public static bool operator true(OverloadingTrueAndFalse obj)
    {
        if (obj.num - obj.symb >= 10) return true;
        else return false;
    }
    public static bool operator false(OverloadingTrueAndFalse obj)
    {
        if (obj) return false;
        else return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        OverloadingTrueAndFalse obj = new OverloadingTrueAndFalse(97, 'O');
        while(obj)
        {
            Console.WriteLine(obj.symb);
            obj.symb++;
        }
    }
}