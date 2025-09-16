public struct MyStruct
{
    public char symb;
    public int num;
    public void Show()
    {
        Console.WriteLine($"symb = {symb}, num = {num}");
    }
}
public class PointerToStructAndItsFieldsAndMethods
{
    static unsafe void Main(string[] arg)
    {
        MyStruct myStruct;
        MyStruct* pMyStruct = &myStruct;
        pMyStruct->symb = 'A';
        pMyStruct->num = 10;
        pMyStruct->Show();
    }
}