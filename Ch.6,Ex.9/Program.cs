class DeterminingSmallestBiggestAndAverageValuesInAnArray
{
    static int GetMaxVal(params int[] values)
    {
        int max = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }
    static int GetMinVal(params int[] values)
    {
        int min = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }
        return min;
    }
    static int GetAvVal(params int[] values)
    {
        int sum = 0;
        int count = values.Length;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        int avValue = sum / count;
        return avValue;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(GetMaxVal(4, 56, 29, 61, 73, 74, 0, -3));
        Console.WriteLine(GetMinVal(65, 888, 72, 50, 32, 55, 882, 82, 0, -57));
        Console.WriteLine(GetAvVal(10, 30, 50));
    }
}