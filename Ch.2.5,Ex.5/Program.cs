class Program
{
    static int GetElementIndex(int[] array, int element)
    {
        int index = Array.IndexOf(array, element);

        if (index == -1)
        {
            throw new ArgumentException("Element not found in the array.", element.ToString());
        }
        return index;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter an array of integers (space-separated):");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Enter the element to find its index:");
            int elementToFind = int.Parse(Console.ReadLine());

            int index = GetElementIndex(nums, elementToFind);
            Console.WriteLine($"Element found at index: {index}");

            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error with element search: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Input format error. Enter a valid integer array with integers separated by spaces.");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Number too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine();
            Main(args);
        }
    }
}