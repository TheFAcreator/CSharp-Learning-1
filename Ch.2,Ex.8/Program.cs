using Microsoft.VisualBasic;
using System;

class ChangingTheThirdBinaryBit
{
    static void Main(string[] args)
    {
        byte num = byte.Parse(Interaction.InputBox("Enter a number between 0 and 255:", "Number"));
        byte copy = num;
        int bit1 = 0, bit2 = 0, bit3 = 0, bit4 = 0, bit5 = 0, bit6 = 0, bit7 = 0, bit8 = 0;
        bit1 = num % 2;
        num = (byte)(num / 2);
        if (num > 0)
        {
            bit2 = num % 2;
            num = (byte)(num / 2);
            if (num > 0)
            {
                bit3 = num % 2;
                num = (byte)(num / 2);
                if (num > 0)
                {
                    bit4 = num % 2;
                    num = (byte)(num / 2);
                    if (num > 0)
                    {
                        bit5 = num % 2;
                        num = (byte)(num / 2);
                        if (num > 0)
                        {
                            bit6 = num % 2;
                            num = (byte)(num / 2);
                            if (num > 0)
                            {
                                bit7 = num % 2;
                                num = (byte)(num / 2);
                                if (num > 0)
                                {
                                    bit8 = num % 2;
                                }
                            }
                        }
                    }
                }
            }
        }
        bit3 = 1;
        int newNum = 0;
        newNum += bit8 * 128;
        newNum += bit7 * 64;
        newNum += bit6 * 32;
        newNum += bit5 * 16;
        newNum += bit4 * 8;
        newNum += bit3 * 4;
        newNum += bit2 * 2;
        newNum += bit1 * 1;
        MessageBox.Show("New number after changing third bit from your number (" + copy + ") to 1: " + newNum, "Result");
    }
}