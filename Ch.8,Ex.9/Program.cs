class IllegalObjectAssigment
{
    public int num;
    public IllegalObjectAssigment(int num)
    {
        this.num = num;
    }
    public static int operator+(IllegalObjectAssigment obj, IllegalObjectAssigment obj2) 
    {
        return obj.num + obj2.num;
    }
    public static int operator-(IllegalObjectAssigment obj, IllegalObjectAssigment obj2)
    {
        return obj.num - obj2.num;
    }
    public static int operator*(IllegalObjectAssigment obj, IllegalObjectAssigment obj2)
    {
        return obj.num * obj2.num;
    }
    public static implicit operator IllegalObjectAssigment(int num)
    {
        return new IllegalObjectAssigment(num);
    }
}
class Program
{
    static void Main(string[] args)
    {
        IllegalObjectAssigment obj = new IllegalObjectAssigment(7);
        IllegalObjectAssigment obj2 = new IllegalObjectAssigment(3);
        obj2 += obj;
        Console.WriteLine(obj2.num);
        obj -= obj2;
        Console.WriteLine(obj.num);
        obj *= obj2;
        Console.WriteLine(obj.num);
    }
}