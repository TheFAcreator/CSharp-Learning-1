using Microsoft.VisualBasic;

class MonthDays
{
    static void Main(string[] args)
    {
        string month, parse;
        int dayCount;
        month = Interaction.InputBox("Enter the name of the month", "Month name");
        parse = Interaction.InputBox("Enter the count of the days in this month", "Day count");
        dayCount = Int32.Parse(parse);
        MessageBox.Show($"{month} has {dayCount} days!", "Result");
    }
}