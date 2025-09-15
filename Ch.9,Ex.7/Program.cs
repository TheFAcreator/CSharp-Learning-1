class GettingBinaryBit
{
    public uint num;
    public int this[int u]
    {
        get
        {
            string binaryCode = string.Empty;
            for (uint i = num; i > 0;)
            {
                binaryCode += i % 2;
                i /= 2;
            }
            string result = binaryCode[u].ToString();
            return Convert.ToInt32(result);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        GettingBinaryBit obj = new GettingBinaryBit();
        obj.num = 87;
        Console.WriteLine(obj.num);
        Console.WriteLine(obj[4 - 1]);
        for (int i = 6; i >= 0; i--)
        {
            Console.Write(obj[i] + " ");
        }
    }
}