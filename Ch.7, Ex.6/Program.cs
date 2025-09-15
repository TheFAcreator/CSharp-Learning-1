class CharArrayInReturn
{
    static char[] GetChars(string txt)
    {
        string result1 = "";
        char[] puncts = { '!', '?', '.', ',', '(', ')', ' ', '\'', '\"', ':', ';' };
        for (int i = 0; i < txt.Length; i++)
        {
            for (int j = 0; j < puncts.Length; j++)
            {
                if (txt[i] == puncts[j]) j += 12;
                else
                {
                    if (j == puncts.Length - 1)
                    {
                        if (result1.Length != 0)
                        {
                            for (int k = 0; k < result1.Length; k++)
                            {
                                if (txt[i] != result1[k])
                                {
                                    if (k == result1.Length - 1) result1 += txt[i];
                                }
                                else k += 19;
                            }
                        }
                        else result1 += txt[i];
                    }
                }
            }
        }
        char[] result2 = new char[result1.Length];
        for (int i = 0; i < result1.Length; i++)
        {
            result2[i] = result1[i];
        }
        char s;
        for (int i = 0; i < result2.Length; i++)
        {
            for (int j = 0; j < result2.Length - 1 - i; j++)
            {
                if (result2[j] > result2[j + 1])
                {
                    s = result2[j];
                    result2[j] = result2[j + 1];
                    result2[j + 1] = s;
                }
            }
        }
        return result2;
    }
    static void Main(string[] args)
    {
        string str = "Hey, do you love cats?";
        char[] newChar = GetChars(str);
        foreach(char c in newChar)
        {
            Console.Write(c + ", ");
        }
        Console.Write("\b\b");
    }
}