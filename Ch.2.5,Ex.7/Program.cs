class IntArrayIndexer
{
    private int[] array;

    public int this[int index]
    {
        get => array[index];
        set => array[index] = value;
    }
    
    public static int GetSize(IntArrayIndexer obj)
    {
        return obj.array.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        IntArrayIndexer obj = new();
        try
        {
            IntArrayIndexer.GetSize(obj);
        }
        catch (Exception e)
        {
            PrintException(e);
        }

        try
        {
            obj[0] = 42;
        }
        catch (Exception e)
        {
            PrintException(e);
        }

        try
        {
            int value = obj[0];
        }
        catch (Exception e)
        {
            PrintException(e);
        }

        static void PrintException(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            Console.WriteLine("Type: " + e.GetType().FullName);
            Console.WriteLine();
        }
    }
}