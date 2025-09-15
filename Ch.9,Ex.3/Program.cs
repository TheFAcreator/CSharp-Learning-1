class IntArraySum
{
    private int[] ints;
    public IntArraySum(int num)
    {
        ints = new int[num];
        for (int i = 0; i < num; i++)
        {
            ints[i] = i;
        }
    }
    public int Sum
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        IntArraySum obj = new IntArraySum(10);
        Console.WriteLine(obj.Sum);
    }
}