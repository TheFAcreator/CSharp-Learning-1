class CustomOverflowException : Exception
{
    public CustomOverflowException() : base("Index is above the bounds of the array.")
    {
    }
}

class NegativeIndexException : ApplicationException
{
    public NegativeIndexException(string message) : base(message)
    {
    }
}

class CharArrayIndexing
{
    private char[] array;

    public CharArrayIndexing()
    {
        array = new char[10];
    }

    public char this[int index]
    {
        get
        {
            if(index < 0)
            {
                throw new NegativeIndexException("Index cannot be negative.");
            }
            if(index >= array.Length)
            {
                throw new CustomOverflowException();
            }

            return array[index];
        }
        set
        {
            if(index < 0)
            {
                throw new NegativeIndexException("Index cannot be negative.");
            }
            if(index >= array.Length)
            {
                throw new CustomOverflowException();
            }

            array[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CharArrayIndexing charArray = new CharArrayIndexing();

        try
        {
            charArray[-1] = 'A'; // This will throw NegativeIndexException
        }
        catch (NegativeIndexException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            charArray[0] = 'A'; // This will work if array is initialized
            Console.WriteLine(charArray[0]); // Output: A

            charArray[10] = 'B'; // This will throw CustomOverflowException
        }
        catch (CustomOverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}