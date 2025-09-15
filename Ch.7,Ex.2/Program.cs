class ReverseWords
{
    static string Reverse(string text)
    {
        string[] txt = text.Split();
        string s;
        for (int i = 0; i < txt.Length / 2; i++)
        {
            s = txt[i];
            txt[i] = txt[txt.Length - 1 - i];
            txt[txt.Length - 1 - i] = s;
        }
        string newText = "";
        for (int i = 0; i < txt.Length; i++)
        {
            newText += txt[i] + " ";
        }
        return newText;
    }
    static void Main(string[] args)
    {
        string str = "Do I love cats that much?";
        string newStr;
        newStr = Reverse(str);
        Console.WriteLine(newStr);
    }
}