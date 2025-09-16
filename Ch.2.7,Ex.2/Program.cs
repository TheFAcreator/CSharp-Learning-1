static void MoveElementsForward<T>(T[] array)
{
    if (array == null || array.Length == 0)
    {
        return; // No elements to move
    }

    T firstElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        array[i - 1] = array[i];
    }
    array[array.Length - 1] = firstElement; // Move the first element to the end
}

int[] nums = { 7, 8, 9, 10, 11 };
foreach (var num in nums)
{
    Console.WriteLine(num);
}
Console.WriteLine();

MoveElementsForward(nums);
foreach(var num in nums)
{
    Console.WriteLine(num);
}