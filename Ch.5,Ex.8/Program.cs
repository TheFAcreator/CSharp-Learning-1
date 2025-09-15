class TwoMethodsForStartAndEnd
{
    static int[] fromStartToEndInt(int start, int end)
    {
        int[] result = new int[end - start + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = start;
            start++;
        }
        return result;
    }
    static char[] fromStartToEndChar(char start, int end)
    {
        char[] result = new char[end - start + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = start;
            start++;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int start = 7, end = 10;
        char start1 = 'f', end1 = 'p';
        int[] ints = new int[end - start];
        ints = fromStartToEndInt(start, end);
        char[] chars = new char[end - start];
        chars = fromStartToEndChar(start1, end1);
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < chars.Length; i++)
        {
            Console.Write(chars[i] + " ");
        }
    }
}