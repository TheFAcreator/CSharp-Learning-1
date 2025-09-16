public class BytesOfTwoIntsInAnArray
{
    static unsafe void Main(string[] args)
    {
        int[] array = new int[2];
        fixed (int* p = array)
        {
            byte* bytePtr = (byte*)p;
            for (int i = 0; i < sizeof(int) * 2; i++)
            {
                bytePtr[i] = (byte)i;
                Console.WriteLine(*(bytePtr + i));
            }
            Console.WriteLine(p[0]);
            /*
                0x00
                0x01
                0x02
                0x03
                0x03020100 = 50462976
             */
            Console.WriteLine(p[1]);
            /*
                0x04
                0x05
                0x06
                0x07
                0x07060504 = 117835012
             */
        }
    }
}
