
using System.Diagnostics;

class NewSmallerArray
{
    static int[] shortenedArray(int[] a, int b)
    {
        int[] ints;
        if (b > a.Length)
        {
            ints = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                ints[i] = a[i];
            }
        }
        else
        {
            ints = new int[a.Length - b];
            for (int i = 0; i < ints.Length; b++, i++)
            {
                ints[i] = a[b];
            }
        }
        return ints;
    }
    static void Main(string[] args)
    {
        int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
        int num = 4;
        int[] ints2 = shortenedArray(ints, num);
        for (int i = 0; i < ints2.Length; i++)
        {
            Console.Write(ints2[i] + " ");
        }
    }
}