class IntervalsInNewString
{
    static string PutIntervals(string txt)
    {
        string newTxt = "";
        for (int i = 0; i < txt.Length; i++)
        {
            newTxt += txt[i] + " ";
        }
        return newTxt;
    }
    static void Main(string[] args)
    {
        string str = "I love cats!";
        string newStr;
        newStr = PutIntervals(str);
        Console.WriteLine(newStr);
    }
}