class IndifferentStringComparison
{
    static bool IndStrCmp(string s1, string s2)
    {
        if (s1.Length  != s2.Length)
        {
            return false;
        }
        else
        {
            bool result = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i] || s1[i] + 1 == s2[i] || s1[i] == s2[i] + 1)
            {
                result = true;
            }
            else
            {
                result = false;
            } 
            }return result;
        }
        
    }
    static void Main(string[] args)
    {
        string str1 = "I love being loved!";
        string str2 = "Shea\'s cute";
        string str3 = "That\'s clandestine!";
        string str4 = "abc";
        string str5 = "abc";
        string str6 = "abb";
        bool result;
        result = IndStrCmp(str1, str2);
        Console.WriteLine(result);
        result = IndStrCmp(str2, str3);
        Console.WriteLine(result);
        result = IndStrCmp(str4, str5);
        Console.WriteLine(result);
        result = IndStrCmp(str5, str6);
        Console.WriteLine(result);
    }
}