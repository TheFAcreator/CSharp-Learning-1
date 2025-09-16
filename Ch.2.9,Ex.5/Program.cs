static bool AreTheSame(DateTime date1, DateTime date2, TimeSpan timeSpan)
{
    return Math.Abs((date1 - date2).TotalSeconds) <= timeSpan.TotalSeconds;
}
Console.WriteLine("Enter first date (yyyy-MM-dd):");
var date1 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter second date (yyyy-MM-dd):");
var date2 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter time span in seconds:");
var seconds = int.Parse(Console.ReadLine());

var timeSpan = TimeSpan.FromSeconds(seconds);
var result = AreTheSame(date1, date2, timeSpan);
Console.WriteLine($"Are the two dates the same within the given time span? {result}" +
    $"\nDifference - {Math.Abs((date1 - date2).TotalSeconds)} seconds.");