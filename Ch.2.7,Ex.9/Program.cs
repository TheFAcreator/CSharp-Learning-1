class ArrayMerging<T>
{
    public T[] array;

    public static ArrayMerging<T> operator +(ArrayMerging<T> a1, ArrayMerging<T> a2)
    {
        ArrayMerging<T> result = new ArrayMerging<T>();

        result.array = new T[a1.array.Length + a2.array.Length];
        a1.array.CopyTo(result.array, 0);
        a2.array.CopyTo(result.array, a1.array.Length);
        
        return result;
    }
}

class ExampleClass
{
    public int Value { get; set; }
    public ExampleClass(int value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ArrayMerging<int> arr1 = new ArrayMerging<int>();
        arr1.array = [2, 4, 6, 8, 10];
        
        ArrayMerging<int> arr2 = new ArrayMerging<int>();
        arr2.array = [1, 3, 5, 7, 9];

        ArrayMerging<int> arr3 = arr1 + arr2;
        foreach (var item in arr3.array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        ArrayMerging<ExampleClass> arr4 = new ArrayMerging<ExampleClass>();
        arr4.array = [new ExampleClass(2), new ExampleClass(4), new ExampleClass(6), new ExampleClass(8), new ExampleClass(10)];

        ArrayMerging<ExampleClass> arr5 = new ArrayMerging<ExampleClass>();
        arr5.array = [new ExampleClass(1), new ExampleClass(3), new ExampleClass(5), new ExampleClass(7), new ExampleClass(9)];

        ArrayMerging<ExampleClass> arr6 = arr4 + arr5;
        foreach (var item in arr6.array)
        {
            Console.Write(item + " ");
        }
    }
}