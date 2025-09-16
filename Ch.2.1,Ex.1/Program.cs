abstract class Base
{
    protected int[] nums;
    public Base(int n)
    {
        nums = new int[n];
    }
    public int Length
    {
        get
        {
            return nums.Length;
        }
    }
    abstract public void Content();
    abstract public int this[int index]
    {
        get; set;
    }
}
class AbstractAndNon_abstract : Base
{
    public AbstractAndNon_abstract(int n) : base(n) { }
    public override void Content()
    {
        for(int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
    public override int this[int index]
    {
        get
        {
            return nums[index];
        }
        set
        {
            nums[index] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        AbstractAndNon_abstract obj = new AbstractAndNon_abstract(8);
        for(int i = 0; i < obj.Length; i++)
        {
            obj[i] = i;
        }
        obj.Content();
        Console.WriteLine();
        for(int i = 0; i < obj.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj[5] = 54;
        obj.Content();
    }
}