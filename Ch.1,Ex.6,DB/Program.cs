using Microsoft.VisualBasic;

class NameAndAge
{
    static void Main(string[] args)
    {
        string name, parse;
        int dateOfBirth, age;
        name = Interaction.InputBox("Enter your name below:", "Profile creator");
        parse = Interaction.InputBox("Enter your date of birth:", "Profile creator");
        dateOfBirth = int.Parse(parse);
        age = 2024 - dateOfBirth;
        MessageBox.Show($"Hi {name}, your age is approximately {age} years!", "Profile created!");
    }
}