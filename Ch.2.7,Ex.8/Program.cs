static void PrintType<T>(T value)
{
    if (value is int)
    {
        Console.WriteLine("Value is an int (integer) type.");
    }
    else if (value is char)
    {
        Console.WriteLine("Value is a char (character) type.");
    }
    else
    {
        Console.WriteLine($"Value is of an unknown type ({value.GetType().Name}).");
    }
}

PrintType(42);        // Output: Value is an int (integer) type.
PrintType('A');      // Output: Value is a char (character) type.
PrintType(3.14);    // Output: Value is of an unknown type (Double).