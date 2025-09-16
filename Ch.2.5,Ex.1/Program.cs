public class UserEntersArrayLength
{
    static void Main(string[] args)
    {
    MyMarker:
        Console.WriteLine("Enter the length of the array:");
        try
        {
            int lehgth = int.Parse(Console.ReadLine());
            int[] ints = new int[lehgth];
            for (int i = 0; i < lehgth; i++)
            {
                ints[i] = i + 1;
                Console.WriteLine(ints[i]);
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid length of the array. Length must be above or equal to zero and not exceed 2147483591.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a whole number or a number at all. Input must be a whole number above or equal to zero and not exceed 2147483591.");
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occurred.");
        }
        goto MyMarker;
    }
}