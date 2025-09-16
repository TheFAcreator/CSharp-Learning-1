interface First
{
    int Value(char symb);
}
interface Second
{
    char Value(int num);
}
class OppositeInterfaces : First, Second
{
    public int Value(char symb)
    {
        return symb;
    }
    public char Value(int num)
    {
        return (char)num;
    }
}
class Program
{
    static void Main(string[] args)
    {
        OppositeInterfaces obj = new OppositeInterfaces();
        Console.WriteLine(obj.Value('A'));
        Console.WriteLine(obj.Value(67));
        First obj2 = new OppositeInterfaces();
        Console.WriteLine(obj2.Value('D'));
        Second obj3 = new OppositeInterfaces();
        Console.WriteLine(obj3.Value('G'));
        Console.WriteLine(obj3.Value(70));
    }
}