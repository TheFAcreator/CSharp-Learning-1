using Microsoft.VisualBasic;

class ChangingForthBitToZero
{
    static void Main(string[] args)
    {
        try
        {
            byte num = byte.Parse(Interaction.InputBox("Enter your number", "Number input"));
            int bit1 = 0, bit2 = 0, bit3 = 0, bit4 = 0, bit5 = 0, bit6 = 0, bit7 = 0, bit8 = 0;
            if (num != 0)
            {
                bit1 = num % 2;
                num /= 2;
                if (num != 0)
                {
                    bit2 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit3 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit4 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit5 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit6 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit7 = num % 2;
                    num /= 2;
                }
                if (num != 0)
                {
                    bit8 = num % 2;
                    num /= 2;
                }
            }
            bit4 = 0;
            int newNum = 0;
            newNum += bit1 * 1;
            newNum += bit2 * 2;
            newNum += bit3 * 4;
            newNum += bit4 * 8;
            newNum += bit5 * 16;
            newNum += bit6 * 32;
            newNum += bit7 * 64;
            newNum += bit8 * 128;
            MessageBox.Show("New number after changing fourth bit zero: " + newNum, "Result", MessageBoxButtons.OK);
        }
        catch
        {
            MessageBox.Show("Your number must be between 0 and 255", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}