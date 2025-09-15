class OddStringComparison
{
    static void CompareStrings(string a, string b)
    {
        char letter = 'a';
        char[] letters = new char[3];
        int k = 0;
        if (a.Length == 3)
        {
            letters[0] = a[0];
            letters[1] = a[1];
            letters[2] = a[2];
        }
        else
        {
            for (int i = 0; i < a.Length;)
            {
                if (letter == a[i])
                {
                    letters[k] = letter;
                    if (k != 2) k++;
                    i++;
                }
                letter++;
            }
        }
        letter = 'z';
        char[] letters2 = new char[3];
        int k2 = 0;
        if (b.Length == 3)
        {
            letters2[0] = b[0];
            letters2[1] = b[1];
            letters2[2] = b[2];
        }
        else
        {
            for (int i = 0; i < b.Length;)
            {
                if (letter == b[i])
                {
                    letters2[k2] = letter;
                    if (k2 != 2) k2++;
                    i++;
                }
                letter--;
            }
        }
        int checker = 0;
        int j = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (letters2[j] == a[i])
            {
                checker++;
                if(j != 2) j++;
            }
        }
        j = 0;
        if (checker >= 3)
        {
            checker = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (letters[j] == b[i])
                {
                    checker++;
                    if (j != 2) j++;
                }
            }
        }
        if (checker >= 3)
        {
            Console.WriteLine("The strings are the same.");
        }
        else
        {
            Console.WriteLine("The strings are not the same.");
        }
    }
    static void Main(string[] args)
    {
        string txt1 = "My cat is here";
        string txt2 = "My cat is not here";
        string txt3 = "Hello there";
        CompareStrings(txt1, txt2);
        CompareStrings(txt1, txt3);
    }
}