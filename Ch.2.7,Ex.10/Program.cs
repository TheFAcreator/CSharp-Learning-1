class DictionaryImitation<T1, T2>
{
    private T1[] keys;
    private T2[] values;
    private int count;

    public int Count => count;

    public DictionaryImitation(int size)
    {
        keys = new T1[size];
        values = new T2[size];
        count = 0;
    }

    public T2 this[T1 key]
    {
        get
        {
            int index = Array.IndexOf(keys, key, 0, count);
            if (index == -1)
                throw new KeyNotFoundException($"Key '{key}' not found.");
            return values[index];
        }
        set
        {
            int index = Array.IndexOf(keys, key, 0, count);
            if (index == -1)
            {
                Add(key, value);
            }
            else
            {
                values[index] = value;
            }
        }
    }

    public void Add(T1 key, T2 value)
    {
        if (Array.IndexOf(keys, key, 0, count) != -1)
            throw new ArgumentException($"Key '{key}' already exists.");

        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length == 0 ? 2 : keys.Length * 2);
            Array.Resize(ref values, values.Length == 0 ? 2 : values.Length * 2);
        }

        keys[count] = key;
        values[count] = value;
        count++;
    }

    public void Remove(T1 key)
    {
        int index = Array.IndexOf(keys, key, 0, count);
        if (index == -1) return;

        keys[index] = keys[count - 1];
        values[index] = values[count - 1];

        count--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DictionaryImitation<char, string> obj = new DictionaryImitation<char, string>(1);
        
        obj.Add('g', "giga");
        obj.Add('t', "terra");
        obj['m'] = "mega";

        Console.WriteLine(obj.Count);
        Console.WriteLine(obj['g']);
        Console.WriteLine(obj['t']);
        Console.WriteLine(obj['m']);

        obj.Remove('m');
        obj.Remove('t');

        Console.WriteLine(obj.Count);
    }
}