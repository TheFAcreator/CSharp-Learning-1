class IntArrayOperations
{
    int[] array;
    public IntArrayOperations()
    {
        Random rnd = new Random();
        int length = rnd.Next(1, 21);
        array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(0, 101);
        }
    }
    public override string ToString()
    {
        string txt = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            txt += array[i] + " ";
        }

        txt += "\nArray length: " + array.Length;
        txt += "\nAverage value: " + array.Average();
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        IntArrayOperations obj = new IntArrayOperations();
        Console.WriteLine(obj);
    }
}