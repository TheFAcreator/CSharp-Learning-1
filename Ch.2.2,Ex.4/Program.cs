delegate int Powering(int power);
class PoweringANumberByIndex
{
    Powering this[int i]
    {
        get
        {
            return n =>
            {
                int p = n;
                int n2 = 1;
                for (int j = 0; j < i; j++) n2 *= p;
                return n2;
            };
        }
    }
    static void Main(string[] args)
    {
        PoweringANumberByIndex obj = new PoweringANumberByIndex();
        int num = obj[3](2);
        Console.WriteLine(num);
    }
}