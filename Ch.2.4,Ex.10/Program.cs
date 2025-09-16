class PointerToPointer
{
    unsafe static void Main(string[] args)
    {
        int num;
        char* ptr2;
        char** ptr = &ptr2;

        *ptr = (char*)&num; // address for ptr2
        **ptr = 'A'; // value for ptr2
        *(*ptr + 1) = 'B'; // value for ptr2

        Console.WriteLine(num); // Output: 4325441
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