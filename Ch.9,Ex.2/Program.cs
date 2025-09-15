class CyclingElements
{
    int[] ints;
    private static int currentElement = 0;
    public CyclingElements(int a)
    {
        ints = new int[a];
        for (int i = 0; i < a; i++) ints[i] = i;
    }
    public int elementSelecter
    {
        get
        {
            int a = ints[currentElement];
            if(currentElement != ints.Length - 1) currentElement++;
            else currentElement = 0;
                return a;
        }
        set
        {
            ints[currentElement] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        CyclingElements obj = new CyclingElements(10);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(obj.elementSelecter);
        }
        obj.elementSelecter = 10;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(obj.elementSelecter);
        }
    }
}