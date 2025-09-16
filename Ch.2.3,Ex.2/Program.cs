public struct MyStruct
{
    public MyStruct(int num, string txt, char ch)
    {
        this.num = num;
        this.txt = txt;
        this.ch = ch;
    }
    public MyStruct(int num, string txt)
    {
        this.num = num;
        this.txt = txt;
        ch = 'a';
    }
    public MyStruct(string txt)
    {
        num = 4;
        this.txt = txt;
        ch = 'b';
    }
    int num;
    string txt;
    char ch;
    public void Show()
    {
        Console.WriteLine("num = {0}, txt = {1}, ch = {2}", num, txt, ch);
    }
}
public class StructWithIntStringChar
{
    static void Main(string[] args)
    {
        MyStruct exp = new MyStruct();
        exp.Show();
        MyStruct exp1 = new MyStruct(1, "Hello", 'c');
        exp1.Show();
        MyStruct exp2 = new MyStruct(2, "World");
        exp2.Show();
        MyStruct exp3 = new MyStruct("Hello World");
        exp3.Show();
    }
}