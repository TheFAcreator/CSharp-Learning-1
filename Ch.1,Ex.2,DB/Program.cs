using Microsoft.VisualBasic;

class AgeName
{
    static void Main(string[] args)
    {
        string name, parse;
        int age;
        parse = Interaction.InputBox("Enter name", "Personal information, name");
        age = int.Parse(parse);
        name = Interaction.InputBox("Enter age", "Personal information, age");
        MessageBox.Show($"Hi, {name}, you are {age} years old!");
    }
}