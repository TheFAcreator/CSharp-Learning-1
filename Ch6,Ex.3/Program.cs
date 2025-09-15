class ThreeConstructors
{
    public int int1, int2;
    public ThreeConstructors()
    {
        int1 = 1;
        int2 = 2;
    }
    public ThreeConstructors(int one)
    {
        int1 = one;
        int2 = 5;
    }
    public ThreeConstructors(int one, int two)
    {
        int1 = one;
        int2 = two;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ThreeConstructors obj = new ThreeConstructors();
        Console.WriteLine(obj.int1 + " " + obj.int2);
        ThreeConstructors obj2 = new ThreeConstructors(72);
        Console.WriteLine(obj2.int1 + " " + obj2.int2);
        ThreeConstructors obj3 = new ThreeConstructors(86, 90);
        Console.WriteLine(obj3.int1 + " " + obj3.int2);
    }
}