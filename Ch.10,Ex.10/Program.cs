class Base
{
    protected int[] ints;
    public Base()
    {
        ints = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    }
    public int this[int num]
    {
        get
        {
            return ints[num];
        }
        set
        {
            ints[num] = value;
        }
    }
    public int Length
    {
        get
        {
            return ints.Length;
        }
    }
}
class ArrayOperations : Base
{
    protected char[] chars;
    public ArrayOperations() : base()
    {
        chars = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    }
    public char this[char symb]
    {
        get
        {
            return chars[symb - 'a'];
        }
        set
        {
            chars[symb - 'a'] = value;
        }
    }
    new public int[] Length
    {
        get
        {
            int[] array = {ints.Length, chars.Length};
            return array;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base();
        for (int i = 0; i < obj.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj[4] = 39;
        for (int i = 0; i < obj.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        ArrayOperations obj2 = new ArrayOperations();
        for (int i = 0; i < obj2.Length[0]; i++)
        {
            Console.Write(obj2[i] + " ");
        }
        Console.WriteLine();
        int j = 0;
        for (char i = 'a'; j < obj2.Length[1]; i++)
        {
            Console.Write(obj2[i] + " ");
            j++;
        }
        Console.WriteLine();
        obj2['d'] = 's';
        for (int i = 0; i < obj2.Length[0]; i++)
        {
            Console.Write(obj2[i] + " ");
        }
        Console.WriteLine();
        int j2 = 0;
        for (char i = 'a'; j2 < obj2.Length[1]; i++)
        {
            Console.Write(obj2[i] + " ");
            j2++;
        }
        Console.WriteLine();
    }
}