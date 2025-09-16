static void ModifyText(ref string text)
{
    text = text.Replace(" ", "_");
    text = new string(text.Select(c => char.IsUpper(c) ? char.ToLower(c) : c).ToArray()); // Or just text.ToLower();
}

using StreamReader reader = new StreamReader("../../../TextFile.txt");
string text = reader.ReadToEnd();
ModifyText(ref text);

using StreamWriter writer = new StreamWriter("../../../TextFile2.txt");
writer.Write(text);

Console.WriteLine("Text modified and saved to TextFile2.txt");