public struct MyStruct
{
    public string txt;
    public MyStruct2 CreateStruct(int num)
    {
        if(num > 0 && num < txt.Length)
        {
             return new MyStruct2
                {
                    symb = txt[num]
                };
        }
        return new MyStruct2();
    }
}
public struct MyStruct2
{
    public char symb;
}
public class TwoStructs_OneCreator
{
    static void Main(string[] args)
    {
        MyStruct exm = new();
        exm.txt = "Hello";
        // Create an instance of MyStruct2 using the CreateStruct method
        MyStruct2 exm2 = exm.CreateStruct(1);
        Console.WriteLine(exm2.symb); // Output: e
        MyStruct2 exm3 = exm.CreateStruct(5);
        Console.WriteLine(exm3.symb); // Output: (default value of char, which is '\0')
        MyStruct2 exm4 = exm.CreateStruct(-5);
        Console.WriteLine(exm4.symb); // Output: (default value of char, which is '\0')
    }
}