public class MyClass
{
    static unsafe void Main(string[] args)
    {
        double num;
        byte*[] pBytes = new byte*[sizeof(double) / 2];
        byte* pNum = (byte*)&num;
        pBytes[0] = pNum;
        pBytes[1] = pNum + 2;
        pBytes[2] = pNum + 4;
        pBytes[3] = pNum + 6;
        pBytes[0][0] = 0x01;
        *(pBytes[0] + 1) = 0x02;
        pBytes[1][0] = 0x03;
        *(pBytes[1] + 1) = 0x04;
        pBytes[2][0] = 0x05;
        *(pBytes[2] + 1) = 0x06;
        pBytes[3][0] = 0x07;
        *(pBytes[3] + 1) = 0x08;
        for(int i = 0; i < sizeof(double); i++)
        {
            Console.WriteLine("pNum[" + i + "] = " + pNum[i]);
        }
        // 0x0807060504030201
        Console.WriteLine("num = " + num);
    }
}