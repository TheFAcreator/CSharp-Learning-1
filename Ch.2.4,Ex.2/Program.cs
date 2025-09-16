public class DoubleMemoryFilling
{
    static unsafe void Main(string[] args)
    {
        double num;
        void* pNum = &num;
        byte* pByte = (byte*)pNum;
        *pByte = 1;
        char* pChar = (char*)pByte + 1;
        pChar[0] = 'A';
        int* pInt = (int*)pByte + 3;
        *pInt = 2;
        pByte[7] = 3;
        Console.WriteLine(*pByte);
        Console.WriteLine(*pChar);
        Console.WriteLine(*pInt);
        Console.WriteLine(pByte[7]);
    }
}