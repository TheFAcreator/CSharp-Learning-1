using System.Collections;

SortedList hashtable = new SortedList(); // or SortedList - the same but with automated sorting of the keys

FillWithFibonacciKeysAndRandomSymbols(hashtable);
foreach (int key in hashtable.Keys)
{
    Console.WriteLine(key + " -> " + hashtable[key]);
}


static void FillWithFibonacciKeysAndRandomSymbols(SortedList hashtable)
{
    Random rnd = new Random();

    hashtable.Add(1, (char)rnd.Next(65, 126));
    hashtable.Add(2, (char)rnd.Next(65, 126));

    for (int i = 0; i < 15; i++)
    {
        List<int> keys = hashtable.Keys.Cast<int>().ToList();

        int key = keys[^1] + keys[^2];
        hashtable.Add(key, (char)rnd.Next(65, 126));
    }
}