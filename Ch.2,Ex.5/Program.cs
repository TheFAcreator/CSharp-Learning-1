using Microsoft.VisualBasic;
using System.Linq.Expressions;

class DeterminingTheThousands
{
    static void Main(string[] args)
    {
        try
        {
            int num = int.Parse(Interaction.InputBox("Enter your number (must be at least 1000)", "Number input"));

            bool check;
            if (num < 1000) check = false;
            else check = true;
            if (check)
            {
                int count = 0;
                for (int i = num; i > 0; i /= 1000)
                {
                    count++;
                }
                int j = num;
                int thousands = 0;
                if (count > 4)
                {
                    while (count > 4)
                    {
                        j /= 10;
                        count--;
                        thousands = j % 10;
                    }
                }
                else
                {
                    j /= 1000;
                    thousands = j % 10;
                }
                MessageBox.Show("The thousands in your number are: " + thousands, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your number is smaller than 1000.", "Invalid number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        catch
        {
            MessageBox.Show("Your input is invalid", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}