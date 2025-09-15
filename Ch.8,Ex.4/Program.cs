class AllComparisonOperators
{
    int num;
    string txt;
    public AllComparisonOperators(int num, string txt)
    {
        this.num = num;
        this.txt = txt;
    }

    public static bool operator >(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.txt.Length > b.txt.Length;
    }
    public static bool operator <(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.txt.Length < b.txt.Length;
    }
    public static bool operator >=(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.num >= b.num;
    }
    public static bool operator <=(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.num <= b.num;
    }
    public static bool operator ==(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.txt == b.txt && a.num == b.num;
    }
    public static bool operator !=(AllComparisonOperators a, AllComparisonOperators b)
    {
        return a.txt != b.txt && a.num != b.num;
    }
    public override bool Equals(object obj)
    {
        AllComparisonOperators obj2 = (AllComparisonOperators) obj;
        return txt == obj2.txt;
    }
    public override int GetHashCode()
    {
        return num ^ txt[0];
    }
}
class Program
{
    static void Main(string[] args)
    {
        AllComparisonOperators obj = new AllComparisonOperators(81, "I love cats.");
        AllComparisonOperators obj2 = new AllComparisonOperators(81, "I love cats");
        AllComparisonOperators obj3 = new AllComparisonOperators(82, "I love cats.");
        AllComparisonOperators obj4 = new AllComparisonOperators(81, "I don\'t love cats.");
        AllComparisonOperators obj5 = new AllComparisonOperators(89, "I love cats");
        Console.WriteLine($"obj > obj2: {obj > obj2}");
        Console.WriteLine($"obj < obj2: {obj < obj2}");
        Console.WriteLine($"obj >= obj3: {obj >= obj3}");
        Console.WriteLine($"obj <= obj3: {obj <= obj3}");
        Console.WriteLine($"obj == obj4: {obj == obj4}");
        Console.WriteLine($"obj != obj5: {obj != obj5}");
        bool equals;
        equals = obj.Equals(obj2);
        Console.WriteLine(equals);
        int getHashCode;
        getHashCode = obj.GetHashCode();
        Console.WriteLine(getHashCode);
    }
}