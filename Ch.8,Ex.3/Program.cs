class TwoDegreeSum
{
    int num1;
    int num2;
    public TwoDegreeSum(int num1,  int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public static bool operator> (TwoDegreeSum left, TwoDegreeSum right)
    {
        int sum1 = left.num1 * left.num1 + left.num2 * left.num2;
        int sum2 = right.num1 * right.num1 + right.num2 * right.num2;
        if (sum1 < sum2) return false;
        else if (sum1 == sum2) return false;
        else return true;
    }
    public static bool operator< (TwoDegreeSum left, TwoDegreeSum right)
    {
        int sum1 = left.num1 * left.num1 + left.num2 * left.num2;
        int sum2 = right.num1 * right.num1 + right.num2 * right.num2;
        if (sum1 > sum2) return false;
        else if (sum1 == sum2) return false;
        else return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        TwoDegreeSum obj = new TwoDegreeSum(3, 8);
        TwoDegreeSum obj2 = new TwoDegreeSum(3, 8);
        TwoDegreeSum obj3 = new TwoDegreeSum(4, 8);
        TwoDegreeSum obj4 = new TwoDegreeSum(3, 7);
        Console.WriteLine("obj < obj2: {0}", obj < obj2);
        Console.WriteLine("obj > obj2: {0}", obj > obj2);
        Console.WriteLine("obj < obj3: {0}", obj < obj3);
        Console.WriteLine("obj > obj4: {0}", obj > obj4);
    }
}