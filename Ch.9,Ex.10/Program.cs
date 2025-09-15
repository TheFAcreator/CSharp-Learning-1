class StringArrayIndexer
{
    string[] txts;
    public StringArrayIndexer(string[] txts)
    {
        this.txts = txts;
    }
    public string this[int i]
    {
        get
        {
            int ind = i;
            for (int j = 0, j2 = 0; j2 <= i; j++, j2++)
            {
                if(j == txts.Length)
                {
                    j = 0;
                }
                ind = j;
            }
            return txts[ind];
        }
        set
        {
            int ind = i;
            for (int j = 0, j2 = 0; j2 <= i; j++, j2++)
            {
                if (j == txts.Length)
                {
                    j = 0;
                }
                ind = j;
            }
            txts[ind] = value;
        }
    }
    public char this[int i, int j]
    {
        get
        {
            int ind = i;
            int ind2 = j;
            for (int i2 = 0, i22 = 0; i22 <= i; i2++, i22++)
            {
                if (i2 == txts.Length)
                {
                    i2 = 0;
                }
                ind = i2;
            }
            for (int j2 = 0, j22 = 0; j22 <= j; j2++, j22++)
            {
                if(j2 == txts[ind].Length)
                {
                    j2 = 0;
                }
                ind = j2;
            }
            return txts[ind][ind2];
        }
        set
        {
            int ind = i;
            int ind2 = j;
            for (int i2 = 0, i22 = 0; i22 <= i; i2++, i22++)
            {
                if (i2 == txts.Length)
                {
                    i2 = 0;
                }
                ind = i2;
            }
            for (int j2 = 0, j22 = 0; j22 <= j; j2++, j22++)
            {
                if (j2 == txts[ind].Length)
                {
                    j2 = 0;
                }
                ind2 = j2;
            }
            char[] array = txts[ind].ToCharArray();
            array[ind2] = value;
            txts[ind] = new string(array);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string[] array = { "gossip", "girl", "gone", "bad" };
        StringArrayIndexer obj = new StringArrayIndexer(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj[3] = "good";
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj[1] += " -";
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        obj[0, 0] = 'G';
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(obj[i][j]);
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}