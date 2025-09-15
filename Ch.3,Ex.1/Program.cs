using Microsoft.VisualBasic;
using System.Linq.Expressions;

class DivisionByThreeAndSeven
{
    static void Main(string[] args)
    {
        int num;
 
        try
        {
            num = int.Parse(Interaction.InputBox("Enter a whole number: "));
            if (num % 3 == 0 && num % 7 == 0)
            {
                MessageBox.Show("Your number can be devided by 3 and 7 without a remainder", "Result");
            }
            else
            {
                MessageBox.Show("Your number can\'t be devided by 3 and 7 without a remainder", "Result");
            }
        }
        catch
        {
            MessageBox.Show("You didn\'t enter a whole number.");
        }
    }
}