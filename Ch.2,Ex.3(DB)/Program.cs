using Microsoft.VisualBasic;

class DevideBy4AndGreaterThan10
{
    static void Main(string[] args)
    {
        int num;
        num = int.Parse(Interaction.InputBox("Enter a whole number", "Greater than 10 and devide by 4"));
        if (num >= 10 && num % 4 == 0)
        {
            MessageBox.Show("Your number is greater than 10 and can be devided by 4 (without a remainder).", "Correct");
        }
        else
        {
            MessageBox.Show("Your number is not greater than 10 or cannot be devided by 4 without a remainder (or both).", "Incorrect");
        }
    }
}