using Microsoft.VisualBasic;

class DevideByThree
{
    static void Main(string[] args)
    {
        int num;
        num = int.Parse(Interaction.InputBox("Enter a whole number:", "Number devision by three"));
        _ = num % 3 == 0 ? MessageBox.Show("Your number can be devided by 3 without a remainder", "Correct") : MessageBox.Show("Your number cannot be devided by 3 without a remainder", "Incorrect");
    }
}