char[] array = new char[25];

Thread fillEvenIndicesWithLatinLetters = new(() =>
{
    for (int i = 0; i < array.Length; i += 2)
    {
        array[i] = (char)('A' + (i / 2));

        Console.Write(array[i] + "|");

        Thread.Sleep(500);
    }
});

Thread fillOddIndicesWithCyrillicLetters = new(() =>
{
    char[] cyrillicLetters = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ".ToCharArray();

    for (int i = 1; i < array.Length; i += 2)
    {
        array[i] = cyrillicLetters[i / 2];

        Console.Write(array[i] + "|");

        Thread.Sleep(500);
    }
});

Console.Write("Array: |");

Thread.Sleep(700);

fillEvenIndicesWithLatinLetters.Start();

Thread.Sleep(100);

fillOddIndicesWithCyrillicLetters.Start();