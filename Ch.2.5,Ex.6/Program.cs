public class EvenOrOddInCatchBlocks
{
    static void EvenOrOdd(int num)
    {
        if (num % 2 == 0)
            throw new ArithmeticException("Number is even");
        else
            throw new OverflowException("Number is odd");
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                EvenOrOdd(num);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                break;
            }
            catch (ArgumentNullException ex)
            {
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}