delegate double SquareEquation(double x);
class SquareEquationOperations
{
    static SquareEquation SqrEqtn(double a, double b, double c)
    {
        return x => a*x*x + b*x + c;
    }
    static void Main(string[] args)
    {
        SquareEquation del = SqrEqtn(2, 3, 5);
        Console.WriteLine(del(2));
        del = SqrEqtn(2.3, 3.5, 5.1);
        Console.WriteLine(del(2.8));
    }
}