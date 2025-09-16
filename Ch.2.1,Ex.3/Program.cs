interface First
{
    int Get();
}
class Derived : First
{
    int num;
    public Derived(int num)
    {
        this.num = num;
    }
    public int Get()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; count < num; i++)
        {
            if(i % 2 == 0)
            {
                sum += i;
                count++;
            }
        }
        return sum;
    }
}
class EvenAndOddSums : First
{
    int num;
    public EvenAndOddSums(int num)
    {
        this.num = num;
    }
    public int Get()
    {
        int sum = 0;
        int count = 0;
        for(int i = 0; count < num; i++)
        {
            if(i % 2 == 1)
            {
                sum += i;
                count++;
            }
        }
        return sum;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Derived obj = new Derived(5);
        Console.WriteLine(obj.Get());
        First obj2 = new EvenAndOddSums(5);
        Console.WriteLine(obj2.Get());
    }
}