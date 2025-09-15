class Arrays
{
    static int[] Codes(params char[] symbs)
    {
        int[] ints = new int[symbs.Length];
        for (int i = 0; i < symbs.Length; i++)
        {
            ints[i] = symbs[i];
        }
        return ints;
    }
    static void Main(string[] args)
    {
        int[] nums = Codes('d', 's', 'f', 'u', 't', 'r');
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}