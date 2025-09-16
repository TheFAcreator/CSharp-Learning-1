public class MyClass
{
    public int num;
}
public class ObjectIntFieldUsageForTwoChars
{
    static unsafe void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        fixed(int* p = &myClass.num)
        {
            char* pChar = (char*)p;
            *pChar = 'A';
            *(pChar + 1) = 'B';
            Console.WriteLine(myClass.num); // Output: 4325441
            /*
            byte 0: 0x41 ('A')
            byte 1: 0x00
            byte 2: 0x42 ('B')
            byte 3: 0x00

            int value = 0x00420041;
            1 + 4 × 16 + 2 × 16^4 + 4 × 16^5 = 4325441
            */
        }
    }
}