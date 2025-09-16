class IntToByteChecked
{
    byte[] array;
    public int this[int index]
    {
        get { return array[index]; }
        set
        {
            array[index] = checked((byte)value);
        }
    }

    public IntToByteChecked(int size)
    {
        array = new byte[size];
    }
}
class Program
{
    static void Main(string[] args)
    {
        IntToByteChecked obj = new IntToByteChecked(5);
        try
        {
            obj[0] = 211; // fine
            obj[1] = 38372; // error
            obj[-1] = 3333; // not even reached
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value is too big for a byte type - max: 255 (min - 0).");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}