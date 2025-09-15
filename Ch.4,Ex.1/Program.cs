class FirstArray
{
    static void Main(string[] args)
    {
        int decision = 0, num = 2;
        Console.Title = "Length";
        try
        {
            Console.Write("How long do you want the list to be: ");
            decision = int.Parse(Console.ReadLine());
        } catch 
        {
            Console.WriteLine("You didn\'t enter a valid value.");
        }
        int[] ints = new int[decision];
        for (int i = 0; i < ints.Length;)
        {
            if (num % 5 == 2)
            {
                ints[i] = num;
                i++;
            }
            num++;
        }
        foreach (int i in ints) 
        {
            Console.WriteLine(i);
        }
    }
}