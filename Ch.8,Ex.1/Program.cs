using System.Linq.Expressions;

class PlusAndMinusMethods
{
    char symb;
    public PlusAndMinusMethods(char symb)
    {
        this.symb = symb;
    }
    public static PlusAndMinusMethods operator++(PlusAndMinusMethods obj)
    {
        obj.symb++;
        return obj;
    }
    public static PlusAndMinusMethods operator--(PlusAndMinusMethods obj)
    {
        obj.symb--;
        return obj;
    }
    public static PlusAndMinusMethods operator+(PlusAndMinusMethods obj, int num)
    {
        obj.symb += (char)num;
        return obj;
    }
    public static PlusAndMinusMethods operator+(int num, PlusAndMinusMethods obj)
    {
        obj += (char)num;
        return obj;
    }
    public static int operator-(PlusAndMinusMethods obj, PlusAndMinusMethods obj2)
    {
        int num;
        num = obj.symb - obj2.symb;
        return num;
    }
    public override string ToString()
    {
        string result = "Char field: " + symb;
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        PlusAndMinusMethods obj = new PlusAndMinusMethods('C');
        Console.WriteLine(obj);
        PlusAndMinusMethods obj2 = obj++;
        Console.WriteLine(obj2);
        PlusAndMinusMethods obj3 = obj--;
        Console.WriteLine(obj3);
        PlusAndMinusMethods obj4 = obj + 1;
        Console.WriteLine(obj4);
        PlusAndMinusMethods obj5 = 2 + obj;
        Console.WriteLine(obj5);
        PlusAndMinusMethods obj6 = new PlusAndMinusMethods('A');
        Console.WriteLine(obj6);
        int num = obj - obj6;
        Console.WriteLine(num);
    }
}