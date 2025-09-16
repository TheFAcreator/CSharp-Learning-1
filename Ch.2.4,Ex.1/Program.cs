class IntPointerWithInnerValues
{
    static unsafe void Main(string[] args)
    {
        int num;
        int* pNum = &num;
        byte* pNumBytes = (byte*)pNum;
        *pNumBytes = 1;
        char* pNumChars = (char*)pNum + 1;
        *pNumChars = 'A';
        pNumBytes[3] = 1;
        for(int i = 0; i < sizeof(int); i++)
        {
            if (pNumBytes[i] == 1) Console.WriteLine($"pNumBytes[{i}] = {pNumBytes[i]}");
            else Console.WriteLine($"pNumBytes[{i}] = {(char)pNumBytes[i]}");
        }
        Console.WriteLine($"pNum = {(uint)num}");
    }
}