int value = 4;

Thread fibbonacci = new(() =>
{
    int a = 0, b = 1, c = default;

    if (value == 0)
    {
        Console.WriteLine(a);
        return;
    }

    for (int i = 0; i < value; i++)
    {
        c = a + b;
        a = b;
        b = c;    
    }
    
    Console.WriteLine("Fibbonacci number: " + c);
});

Thread factorial = new(() =>
{
    int result = 1;

    for (int i = 1; i <= value; i++)
    {
        result *= i;
    }

    Console.WriteLine("Factorial: " + result);
});

Thread doubleFactorial = new(() =>
{
    int result = 1;

    for (int i = value; i > 0; i -= 2)
    {
        result *= i;
    }

    Console.WriteLine("Double factorial: " + result);
});

fibbonacci.Start();
factorial.Start();
doubleFactorial.Start();

// Result will be printed in an unpredictable order, depending on the thread scheduling by the operating system.
// Join() can be used for a specific order.