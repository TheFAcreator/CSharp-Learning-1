using System.Diagnostics;

class ConsonantsInCapitalsArray
{
    static void Main(string[] args)
    {
        int k = 0;
        char[] chars = new char[10];
        for (char i = 'A'; k < chars.Length; i++)
        {
            if (i != 'A' && i != 'E' && i != 'I' && i != 'O' && i != 'U')
            {
                chars[k] = i;
                k++;
            }
        }
        for (int i = 0; i < chars.Length; i++)
        {
            Console.Write(chars[i] + " ");
        }
    }
}