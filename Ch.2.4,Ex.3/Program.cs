public class IntContainingTwoInts
{
    static unsafe void Main(string[] args)
    {
        int num;
        int num1;
        int num2;
        Random random = new Random();
        num1 = random.Next(1, 101);
        num2 = random.Next(1, 101);
        short* pNum1 = (short*)&num1;
        short* pNum2 = (short*)&num2;
        short* pNum = (short*)&num;
        *pNum = *pNum1;
        pNum[1] = *pNum2;
        Console.WriteLine($"num1: {num1}, num2: {num2}");
        Console.WriteLine($"num: {num}");
        char* pNumChar = (char*)&num;
        Console.WriteLine($"{*pNumChar} = {(int)*pNumChar}; {pNumChar[1]} = {(int)pNumChar[1]}");
    }
}