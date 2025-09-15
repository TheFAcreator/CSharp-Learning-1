using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

class ShowingSumAndExtraction
{
    static void Main(string[] args)
    {
        string numbers = Interaction.InputBox("Enter your numbers (separated by an interval)", "Input");
        string[] strings = numbers.Split(' ');
        int num = Convert.ToInt32(strings[0]);
        int num2 = Convert.ToInt32(strings[1]);
        int sum = num + num2;
        int extraction = Math.Abs(num - num2);
        MessageBox.Show($"Sum: {sum}, Extraction: {extraction}.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}