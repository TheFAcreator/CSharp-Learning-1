using Microsoft.VisualBasic;

class WeekdayMonthDate
{
    static void Main(string[] args)
    {
        string weekday, month, parse;
        int date;
        weekday = Interaction.InputBox("What's the current day of the week?", "Weather forecast");
        month = Interaction.InputBox("What's the current month?", "Weather forecast");
        parse = Interaction.InputBox("What's the date?", "Weather forecast");
        date = int.Parse(parse);
        MessageBox.Show($"It's the {date} of {month} - {weekday}. Check the weather for this day in our site!");
    }
}