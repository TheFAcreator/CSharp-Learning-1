class RandomSmallestGreatest
{
    static int[] getMinMax(params int[] a)
    {
        int smallestValue = a[0], greatestValue = a[0];
        int[] ints = new int[2];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < smallestValue)
            {
                smallestValue = a[i];
            }
        }
        for (int i = 0; a.Length > i; i++)
        {
            if (a[i] > greatestValue)
            {
                greatestValue = a[i];
            }
        }
        ints[0] = smallestValue;
        ints[1] = greatestValue;
        return ints;
    }
    static void Main(string[] args)
    {
        int[] ints = getMinMax(4, 3, 77, 76, 94, 46, 99, 97, 76, 98, 6, 7);
        Console.Write("Smallest element: " + ints[0] + "; Greatest element: " + ints[1]);
    }
}