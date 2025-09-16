public class IntBytesRotating
{
    static unsafe void Main(string[] args)
    {
        int num;
        Random random = new Random();
        num = random.Next(0, 1_000);
        Console.WriteLine($"Original number: {num}");
        Console.WriteLine($"Rotating bytes of {num} 4 times");
        RotateBytes(4, ref num);
        Console.WriteLine($"Rotated number: {num}");
        Console.WriteLine();
        Console.WriteLine($"Rotating bytes of {num} 2 times");
        RotateBytes(2, ref num);
        Console.WriteLine($"Rotated number: {num}");
        Console.WriteLine();
    }

    static unsafe void RotateBytes(int count, ref int num)
    {
        fixed (int* pNum = &num)  
        {
            byte* p1 = (byte*)pNum;
            byte* p2 = p1 + 1;
            byte* p3 = p1 + 2;
            byte* p4 = p1 + 3;
            string explanation = $"Explanation:\nBefore rotation: {*p1:x2} {*p2:x2} {*p3:x2} {*p4:x2}\n";
            for (int i = 0; i < count; i++)
            {
                byte temp = *p4;
                *p4 = *p3;
                *p3 = *p2;
                *p2 = *p1;
                *p1 = temp;
                explanation += $"After rotation {i + 1}: {*p1:x2} {*p2:x2} {*p3:x2} {*p4:x2}\n";
            }
            int res = *(int*)p1;
            explanation += $"0x{res:x8}";
            Console.WriteLine(explanation + " = " + res);
            num = res;
        }
    }
}
