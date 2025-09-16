static Stack<int> GetNumsAboveOrEqualToAverage(int[] nums)
{
    double average = nums.Average();
    Stack<int> result = new Stack<int>();
    
    foreach (int num in nums)
    {
        if (num >= average)
        {
            result.Push(num);
        }
    }
    return result;
}


// Example usage
int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
Stack<int> numsAboveOrEqualToAverage = GetNumsAboveOrEqualToAverage(numbers);

Console.WriteLine("Numbers above or equal to average:");
foreach (int num in numsAboveOrEqualToAverage)
{
    Console.WriteLine(num);
}

// Alternatively, you can pop elements from the stack:
//for (int i = 0; i < numsAboveOrEqualToAverage.Count; i++)
//{
//    Console.WriteLine(numsAboveOrEqualToAverage.Pop());
//}