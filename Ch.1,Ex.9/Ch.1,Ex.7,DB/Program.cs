using Microsoft.VisualBasic;

class DateOfBirth
{
    static void Main(string[] args)
    {
        int age, dateOfBirth;
        string parse;
        parse = Interaction.InputBox("Enter your age below:", "Personal information, age");
        age = int.Parse(parse);
        dateOfBirth = 2024 - age;
        MessageBox.Show($"Your date of birth is {dateOfBirth}", "Result");
    }
}