static void SwapValues<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"Swapped values: {a} <-> {b}");
}


int a = 5;
int b = 10;
Console.WriteLine(a + " " + b);

SwapValues(ref a, ref b); // must reference struct types
Console.WriteLine(a + " " + b);