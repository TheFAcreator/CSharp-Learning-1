Console.WriteLine("Enter two years separated by a space (e.g., 1990 2020): ");
var input = Console.ReadLine();
if (input == null)
{
    Console.WriteLine("No input provided.");
    return;
}
var years = input.Split(' ');
if (years.Length != 2 || !int.TryParse(years[0], out int startYear) || !int.TryParse(years[1], out int endYear))
{
    Console.WriteLine("Invalid input. Please enter two valid years.");
    return;
}
if (startYear > endYear)
{
    Console.WriteLine("Start year must be less than or equal to end year.");
    return;
}

for (int year = startYear; year <= endYear; year++)
{
    DateTime january1st = new DateTime(year, 1, 1);
    if (january1st.DayOfWeek == DayOfWeek.Monday)
    {
        Console.WriteLine(january1st.ToString("dd MM yyyy") + " - monday");
    }
}