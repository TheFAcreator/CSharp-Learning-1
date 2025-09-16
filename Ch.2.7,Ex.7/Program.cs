class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 4 };
        SortDescending(numbers);
        Console.WriteLine(string.Join(", ", numbers)); // Output: 8, 5, 4, 2, 1
        
        string[] words = { "banana", "apple", "cherry" };
        Sort(words);
        Console.WriteLine(string.Join(", ", words)); // Output: cherry, banana, apple

        ExampleClass[] examples = {
            new ExampleClass { ExampleProperty = 2, ExampleChar = 'b' },
            new ExampleClass { ExampleProperty = 1, ExampleChar = 'a' },
            new ExampleClass { ExampleProperty = 2, ExampleChar = 'a' }
        };
        Sort(examples);
        foreach (var example in examples)
        {
            Console.WriteLine($"{example.ExampleProperty}, {example.ExampleChar}");
        }
        // Output:
        // 2, b
        // 2, a
        // 1, a
    }

    static void SortDescending<T>(T[] array) where T : IComparable<T>
    {
        Array.Sort(array, (x, y) => y.CompareTo(x));
        Array.Reverse(array);
    }

    static void Sort<T>(T[] array) where T : IComparable<T>
    {
        Array.Sort(array, (x, y) => y.CompareTo(x));
    }
}

class ExampleClass : IComparable<ExampleClass>
{
    public int ExampleProperty { get; set; }
    public char ExampleChar { get; set; }

    public int CompareTo(ExampleClass? other)
    {
        int res = this.ExampleProperty.CompareTo(other?.ExampleProperty);
        if (res != 0) return res;

        return this.ExampleChar.CompareTo(other?.ExampleChar);
    }
}