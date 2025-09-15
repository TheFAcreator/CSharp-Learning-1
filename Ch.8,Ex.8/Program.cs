class ArrayCast
{
    public int[] ints;
    public ArrayCast(int i)
    {
        ints = new int[i];
        for (int j = 0; j < ints.Length; j++)
        {
            ints[j] = j + 1;
        }
    }
    public static implicit operator string(ArrayCast cast)
    {
        string result = "";
        foreach(int i in cast.ints)
        {
            result += i;
        }
        return result;
    }
    public static implicit operator int(ArrayCast cast)
    {
        int result = 0;
        foreach(int i in cast.ints)
        {
            result += i;
        }
        return result;
    }
    public static implicit operator ArrayCast(int num)
    {
        ArrayCast newObj = new ArrayCast(num);
        for (int i = 0; i < newObj.ints.Length; i++)
        {
            newObj.ints[i] = 0;
        }
        return newObj;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ArrayCast obj = new ArrayCast(9);
        string str = obj;
        Console.WriteLine(str);
        int num = obj;
        Console.WriteLine(num);
        ArrayCast obj2 = 14;
        for (int i = 0; i < obj2.ints.Length; i++)
        {
            Console.WriteLine(obj2.ints[i] + " ");
        }
    }
}