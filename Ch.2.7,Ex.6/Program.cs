static Tuple<T, T> getSmallestAndLargest<T>(T[] values) where T : IComparable<T>
{
    T smallest = values[0];
    T largest = values[^1];

    foreach (T value in values)
    {
        if (value.CompareTo(smallest) < 0)
        {
            smallest = value;
        }
        else if (value.CompareTo(largest) > 0)
        {
            largest = value;
        }
    }
    return Tuple.Create(smallest, largest);
}


var intArray = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
var stringArray = new string[] { "apple", "banana", "cherry", "date" };
var doubleArray = new double[] { 3.14, 2.71, 1.41, 1.73 };
var charArray = new char[] { 'z', 'a', 'm', 'e', 't' };
var dateArray = new DateTime[] { new DateTime(2020, 1, 1), new DateTime(2019, 12, 31), new DateTime(2021, 6, 15) };

var intResult = getSmallestAndLargest(intArray);
var stringResult = getSmallestAndLargest(stringArray);
var doubleResult = getSmallestAndLargest(doubleArray);
var charResult = getSmallestAndLargest(charArray);
var dateResult = getSmallestAndLargest(dateArray);

Console.WriteLine($"Int: Smallest = {intResult.Item1}, Largest = {intResult.Item2}");
Console.WriteLine($"String: Smallest = {stringResult.Item1}, Largest = {stringResult.Item2}");
Console.WriteLine($"Double: Smallest = {doubleResult.Item1}, Largest = {doubleResult.Item2}");
Console.WriteLine($"Char: Smallest = {charResult.Item1}, Largest = {charResult.Item2}");
Console.WriteLine($"DateTime: Smallest = {dateResult.Item1.ToShortDateString()}, Largest = {dateResult.Item2.ToShortDateString()}");


// Preprocessor directive example
#if DEBUG
Console.WriteLine("Debug build");
#endif