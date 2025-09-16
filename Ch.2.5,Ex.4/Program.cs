class EquationEdgeCases : ApplicationException
{
    public double x = double.NaN;
    public EquationEdgeCases(string message, double x) : base(message)
    {
        this.x = x;
    }
    public EquationEdgeCases(string message) : base(message)
    {
    }
}
public class Ax2PlusBxPlusCEqualTo0Equation
{
    static void Main(string[] args)
    {
        try
        {
            double a = 0;
            Console.WriteLine("Ax^2 + Bx + C = 0");
            while (true)
            {
                try
                {
                    Console.Write("Enter a number value for A (A cannot be zero): ");
                    a = double.Parse(Console.ReadLine());
                    if (a == 0) throw new EquationEdgeCases("A cannot be zero");
                    break;
                }
                catch (EquationEdgeCases e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unexpected error occurred: " + e.Message);
                }
            }
            Console.WriteLine("{0}x^2 + Bx + C = 0", a);
            double b = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number value for B: ");
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unexpected error occurred: " + e.Message);
                }
            }
            if(b < 0) Console.WriteLine("{0}x^2 {1}x + C = 0", a, b);
            else Console.WriteLine("{0}x^2 + {1}x + C = 0", a, b);
            double c = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number value for C: ");
                    c = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unexpected error occurred: " + e.Message);
                }
            }
            if(b < 0 && c < 0) Console.WriteLine("{0}x^2 {1}x {2} = 0", a, b, c);
            else if (b < 0 && c > 0) Console.WriteLine("{0}x^2 {1}x + {2} = 0", a, b, c);
            else if (b > 0 && c < 0) Console.WriteLine("{0}x^2 + {1}x {2} = 0", a, b, c);
            else Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine("D = {0}", discriminant);
            if (discriminant < 0) throw new EquationEdgeCases("The equation has no real roots");
            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                throw new EquationEdgeCases("The equation has one real root", x);
            }
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The equation has two real roots: x1 = {0}, x2 = {1}", x1, x2);
        }
        catch (EquationEdgeCases e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("x = " + e.x);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
        finally
        {
            Console.WriteLine("End of program.");
        }
    }
}