using Microsoft.VisualBasic;

class ComparingTwoNumbers
{
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0;
        try
        {
            num1 = int.Parse(Interaction.InputBox("Enter your first number:", "First number"));
            num2 = int.Parse(Interaction.InputBox("Enter your second number:", "Second number"));
        }
        catch 
        {
            MessageBox.Show("You didn\'t enter valid numbers.");
        }
        if (num1 > num2)
        {
            MessageBox.Show($"Your first number is greater than your second one. (Numbers: 1. {num1}; 2. {num2}");
        }
        else if(num1 < num2)
        {
            MessageBox.Show($"Your first number is smaller than your second one. (Numbers: 1. {num1}; 2. {num2}");
        }
        else if(num1 == num2)
        {
            MessageBox.Show($"Your numbers are equal. (Numbers: 1. {num1}; 2. {num2}");
        }
    }
}