using Microsoft.VisualBasic;

class NameSurname
{
    static void Main(string[] args)
    {
        string name, surname;
        name = Interaction.InputBox("Enter your name", "Personal information, name");
        surname = Interaction.InputBox("Enter your surname", "Personal informatin, surname");
        MessageBox.Show("Hi, " + name + " " + surname);
    }
}