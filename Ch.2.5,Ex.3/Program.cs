public class AxIsEqualToBEquation
{
    static void Main(string[] args)
    {
        int n = 1;
        int b = 0;
        try
        {
            Console.WriteLine("Enter a whole number for a:");
            int a = int.Parse(Console.ReadLine());
            n++;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a whole number for b:");
                    b = int.Parse(Console.ReadLine());
                    double a2 = a;
                    double b2 = b;
                    if(a2 == 0) throw new DivideByZeroException();
                    if (b2 / a2 - Math.Floor(b2 / a2) == 0)
                        Console.WriteLine("x = " + b2 / a2);
                    else throw new ArithmeticException();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid whole number for b.");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a whole number for a.");
        }
        catch (DivideByZeroException)
        {
            if(b == 0)
            Console.WriteLine("Any number for x is a solution.");
            else
                Console.WriteLine("No solutions.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Solution for x is not a whole number. Enter whole numbers for a and b for which b / a equals a whole number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            n = 1;
            Main(args);
        }
    }
}