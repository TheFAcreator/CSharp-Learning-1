
class ChangingASpecificNumberInsideAUint
{
    public uint num;
    public int this[int i]
    {
        set
        {
            //int j = value % 10;                       This
            //string txt = num.ToString();              is an 
            //txt = txt.Remove(i, 1);                   alternative
            //txt = txt.Insert(i, value.ToString());    which is way
            //num = Convert.ToUInt32(txt);              more simple than below.
            uint l = num;
            int k = 0;
            for (; l > 0;)
            {
                l /= 10;
                k++;
            }
            uint o = num;
            int m = k - i;
            string str = "";
            for (; m > 1; m--)
            {
                str += o % 10;
                o /= 10;
            }
            char[] s = str.ToCharArray();
            string str2 = string.Empty;
            for (int t = s.Length - 1; t >= 0; t--)
            {
                str2 += s[t];
            }
            str = str2;
            o -= o % 10;
            int j2 = value % 10;
            o += (uint)j2;
            string txt2 = o.ToString();
            txt2 += str;
            num = Convert.ToUInt32(txt2);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ChangingASpecificNumberInsideAUint obj = new ChangingASpecificNumberInsideAUint();
        obj.num = 4;
        Console.WriteLine(obj.num);
        obj[0] = 3;
        Console.WriteLine(obj.num);
        obj.num = 2195;
        Console.WriteLine(obj.num);
        obj[1] = 8;
        Console.WriteLine(obj.num);
    }
}