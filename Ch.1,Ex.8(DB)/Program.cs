//This programme is originally for exercise 9(chapter1, dialog box) and the programe named Ch.1,Ex.9(DB) is actually for exercise 8.
using Microsoft.VisualBasic;

class AddictionAndSubstraction
{
    static void Main(string[] args)
    {
        int num, num1, num2;
        num = int.Parse(Interaction.InputBox("Enter a number: ", "Numbers"));
        num1 = num - 1;
        num2 = num + 1;
        MessageBox.Show("Your number ("+num+") is greater than "+num1+" with 1 and smaller than "+num2+" with 1.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}