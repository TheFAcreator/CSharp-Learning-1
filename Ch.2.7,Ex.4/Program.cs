class GenericIndexer<T>
{
    private T[] items;

    public int Length => items.Length;

    public GenericIndexer(int size)
    {
        items = new T[size];
    }
    
    public T this[int index]
    {
        get => items[index];
        set => items[index] = value;
    }

    public void FillWith(T[] values)
    {
        if (values.Length > items.Length)
            throw new ArgumentException("Input array is larger than the indexer size.");
        for (int i = 0; i < values.Length; i++)
        {
            items[i] = values[i];
        }
    }
    public void Clear()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = default(T);
        }
    }
    public void PrintAll()
    {
        if (items.All(i => EqualityComparer<T>.Default.Equals(i, default(T))))
        {
            Console.WriteLine("No items to display.");
            return;
        }

        Console.WriteLine("Items in the indexer:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        GenericIndexer<string> stringIndexer = new GenericIndexer<string>(5);
        stringIndexer[0] = "Hello";
        stringIndexer[1] = "World";
        Console.WriteLine(stringIndexer[0]); // Output: Hello
        Console.WriteLine(stringIndexer[1]); // Output: World
        Console.WriteLine();
        
        GenericIndexer<int> intIndexer = new GenericIndexer<int>(5);
        intIndexer[0] = 42;
        intIndexer[1] = 100;
        Console.WriteLine(intIndexer[0]); // Output: 42
        Console.WriteLine(intIndexer[1]); // Output: 100
        Console.WriteLine();

        intIndexer.FillWith(new int[] { 1, 3, 5, 7, 9 });
        intIndexer.PrintAll(); // Output: 1, 3, 5, 7, 9
        intIndexer.Clear();
        intIndexer.PrintAll(); // Output: No items to display.
    }
}