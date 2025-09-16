class BinaryFiles
{
    public int num;
    public char symb;
    public string txt;
}
class Program
{
    static void Main(string[] args)
    {
        BinaryFiles bf = new BinaryFiles();
        bf.num = 123;
        bf.symb = 'A';
        bf.txt = "Hello, World!";
        
        using (var writer = new BinaryWriter(File.Open("../../../data.bin", FileMode.Create)))
        {
            writer.Write(bf.num);
            writer.Write(bf.symb);
            writer.Write(bf.txt);
        }
        
        BinaryFiles bfRead = new BinaryFiles();
        using (var reader = new BinaryReader(File.Open("../../../data.bin", FileMode.Open)))
        {
            bfRead.num = reader.ReadInt32();
            bfRead.symb = reader.ReadChar();
            bfRead.txt = reader.ReadString();
        }
        Console.WriteLine($"Number: {bfRead.num}, Symbol: {bfRead.symb}, Text: {bfRead.txt}");
    }
}