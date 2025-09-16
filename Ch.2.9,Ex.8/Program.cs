using System.Collections;

string text = "This is a sample text with several words. This text is for testing ArrayList.";

string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

ArrayList wordList = new ArrayList(words);
foreach (string word in wordList)
{
    Console.WriteLine(word);
}