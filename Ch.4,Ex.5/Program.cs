using System.Transactions;

class SmallestElement
{
    static void Main(string[] args)
    {
        int index = 0;
        int value;
        int[] ints = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = rnd.Next(1, 101);
        }
        foreach (int d in ints)
        {
            Console.Write(d + ", ");
        }
        Console.Write("\b\b.");
        Console.WriteLine();
        value = ints[index];
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] < value)
            {
                value = ints[i];
                index = i;
            }
        }
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] == value && ints[i] != ints[index])
            {
                Console.WriteLine("Smallest element: " + value);
                Console.WriteLine("Index: " + index);
            }
        }
        Console.WriteLine("Smallest element: " + value);
        Console.WriteLine("Index: " + index);
    }
}