class Base
{
    public int num;
    protected int GetTenthValue(int i, int ind)
    {
        /*string res = "";
        for (int j = i; j < 1; j++)
        {
            res += (j % 10) + res;
            j /= 10;
        }
        return res;
        */
        int k = 0;
        int j = i;
        do
        {
            j /= 10;
            k++;
        }
        while (j > 1);
        int g = k - ind;
        int sj = i;
        for (; g > 1; g--)
        {
            sj /= 10;
        }
        return sj % 10;
    }
    public virtual int this[int ind]
    {
        get
        {
            return GetTenthValue(num, ind);
        }
    }
}
class GettingTenthValue : Base
{
    public int num2;
    public int this[int ind, int ind2]
    {
        get
        {
            if (ind == 0)
            {
                return GetTenthValue(num, ind2);
            }
            else if (ind == 1)
            {
                return GetTenthValue(num2, ind2);
            }
            else
            {
                Console.WriteLine("Wrong index");
                return 0;
            }
        }
    }
    public override int this[int index]
    {
        get
        {
            return GetTenthValue(num + num2, index);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base();
        obj.num = 34;
        Console.WriteLine(obj[1]);
        obj.num = 6;
        Console.WriteLine(obj[0]);
        GettingTenthValue obj2 = new GettingTenthValue();
        obj2.num = 9;
        obj2.num2 = 4387;
        Console.WriteLine(obj2[0, 0]);
        Console.WriteLine(obj2[1, 2]);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(obj2[1, i]);
        }
        Console.WriteLine(obj2[2]);
    }
}