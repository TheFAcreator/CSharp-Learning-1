class OnlyAFewSpecificCorrectValues
{
    int num;
    public OnlyAFewSpecificCorrectValues(int num)
    {
        this.num = num;
    }

    public static bool operator &(OnlyAFewSpecificCorrectValues obj, OnlyAFewSpecificCorrectValues obj2)
    {
        if (obj)
        {
            if (obj2)
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator |(OnlyAFewSpecificCorrectValues obj, OnlyAFewSpecificCorrectValues obj2)
    {
        if (obj)
        {
            if (obj2)
            {
                return false;
            }
            else return true;
        }
        else
        {
            if (obj2)
            {
                return true;
            }
            else return false;
        }
    }
    public static bool operator true(OnlyAFewSpecificCorrectValues obj)
    {
        switch (obj.num)
        {
            case 2:
            case 3:
            case 5:
            case 7:
            return true;
            default:
            return false;
        }
    }
    public static bool operator false(OnlyAFewSpecificCorrectValues obj)
    {
        if(obj.num < 1 || obj.num > 10) return false;
        else return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        OnlyAFewSpecificCorrectValues obj = new OnlyAFewSpecificCorrectValues(5);
        OnlyAFewSpecificCorrectValues obj2 = new OnlyAFewSpecificCorrectValues(3);
        OnlyAFewSpecificCorrectValues obj3 = new OnlyAFewSpecificCorrectValues(4);
        Console.WriteLine("obj & obj2: {0}", obj & obj2);
        Console.WriteLine("obj | obj2: {0}", obj | obj2);
        Console.WriteLine("obj & obj3: {0}", obj & obj3);
        Console.WriteLine("obj | obj3: {0}", obj | obj3);
    }
}