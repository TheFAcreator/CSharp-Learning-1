class TwoArraysTwoThreads
{
    public int[] ints;
    public char[] chars;

    public TwoArraysTwoThreads(int length1, int length2)
    {
        ints = new int[length1];
        chars = new char[length2];
    }
}
class Program
{
    static void Main(string[] args)
    {
        TwoArraysTwoThreads obj = new(7, 4);

        Thread fillInts = new Thread(() =>
        {
            for (int i = 0; i < obj.ints.Length; i++)
            {
                lock (obj)
                {
                    obj.ints[i] = i * new Random().Next(1, 11);
                }
            }
        });

        Thread fillChars = new Thread(() =>
        {
            for (int i = 0; i < obj.chars.Length; i++)
            {
                lock (obj)
                {
                    obj.chars[i] = (char)new Random().Next(33, 127); // Displayable symbol
                }
            }
        });

        fillInts.Start();
        fillChars.Start();

        fillInts.Join();
        fillChars.Join();

        for (int i = 0; i < obj.ints.Length; i++)
        {
            Console.Write(obj.ints[i] + " ");
        }

        Console.WriteLine();
        for (int i = 0; i < obj.chars.Length; i++)
        {
            Console.Write(obj.chars[i] + " ");
        }
    }
}