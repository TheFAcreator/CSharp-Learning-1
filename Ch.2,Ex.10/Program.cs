using Microsoft.VisualBasic;

class ChangingSecondBitToItsOpposite
{
    static void Main(string[] args)
    {
        try
        {
            byte num = byte.Parse(Interaction.InputBox("Enter your number:", "Number input"));
            byte numCopy = num;
            int bit1 = 0, bit2 = 0, bit3 = 0, bit4 = 0, bit5 = 0, bit6 = 0, bit7 = 0, bit8 = 0;
            if (num != 0)
            {
                numCopy /= 2;
                bit1 = 1;
                if (num != 0)
                {
                    numCopy /= 2;
                    bit2 = 1;
                    if (numCopy != 0)
                    {
                        numCopy /= 2;
                        bit3 = 1;
                        if (numCopy != 0)
                        {
                            numCopy /= 2;
                            bit4 = 1;
                            if (numCopy != 0)
                            {
                                numCopy /= 2;
                                bit5 = 1;
                                if (numCopy != 0)
                                {
                                    numCopy /= 2;
                                    bit6 = 1;
                                    if (numCopy != 0)
                                    {
                                        numCopy /= 2;
                                        bit7 = 1;
                                        if (numCopy != 0)
                                        {
                                            numCopy /= 2;
                                            bit8 = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (bit2 == 0)
            {
                bit2 = 1;
            }
            else
            {
                bit2 = 0;
            }
            int newNum = 0;
            newNum += bit1 * 1;
            newNum += bit2 * 2;
            newNum += bit3 * 4;
            newNum += bit4 * 8;
            newNum += bit5 * 16;
            newNum += bit6 * 32;
            newNum += bit7 * 64;
            newNum += bit8 * 128;
            MessageBox.Show("New number after changing second bit to its opposite: " + newNum + "\nYour number was: " + num, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
            MessageBox.Show("The number you entered is invalid.\nEnter a number between 0 and 255.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}