namespace First
{
    interface IIntValue
    {
        int Value { get; }
    }
}
namespace Second
{
    class BaseClass : First.IIntValue
    {
        public int Value { get; } = 42;
    }
}
namespace Third
{
    using Second;

    class DerivedClass : BaseClass
    {
        public void PrintValue()
        {
            Console.WriteLine(Value);
        }
    }
}
namespace Fourth
{
    class DifferentNamespaces
    {
        static void Main(string[] args)
        {
            var instance = new Third.DerivedClass();
            instance.PrintValue();
        }
    }
}