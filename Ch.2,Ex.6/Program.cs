using Microsoft.VisualBasic;

class CheckingADigitInTheOctalValueOfANumber
{
    static void Main(string[] args)
    {
        int num = int.Parse(Interaction.InputBox("Enter your number:", "Number input"));
        int octalValue = Convert.ToInt32(num.ToString(), 8);
        string oct = octalValue.ToString();
        string character = oct[oct.Length - 2].ToString();
        int digit = Convert.ToInt32(character);
        MessageBox.Show($"{digit}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}