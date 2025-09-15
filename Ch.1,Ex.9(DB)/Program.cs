using Microsoft.VisualBasic;

class Addiction
{
    static void Main(string[] args)
    {
        int num1, num2, sum;
        num1 = int.Parse(Interaction.InputBox("Enter a number below:","Addiction - number 1"));
        num2 = int.Parse(Interaction.InputBox("Enter a second number:", "Addiction - number 2"));
        sum = num1 + num2;
        MessageBox.Show("The summary of your numbers is " + sum + "!","Addiction - result",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
    }
}