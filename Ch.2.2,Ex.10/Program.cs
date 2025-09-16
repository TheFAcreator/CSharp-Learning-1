delegate void MyDelegate(string name);

class EventForShowingObjectName
{
    public event MyDelegate ShowObjectName;

    private string objectName;

    public void RaiseEvent()
    {
        ShowObjectName?.Invoke(objectName);
    }

    public EventForShowingObjectName(string name)
    {
        objectName = name;
    }
}
class AnotherClass
{
    public void Show(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main(string[] args)
    {
        EventForShowingObjectName obj1 = new EventForShowingObjectName("obj1");
        EventForShowingObjectName obj2 = new EventForShowingObjectName("obj2");
        AnotherClass anotherClass = new AnotherClass();
        
        obj1.ShowObjectName += anotherClass.Show;
        obj2.ShowObjectName += anotherClass.Show;

        obj1.RaiseEvent();
        obj2.RaiseEvent();
    }
}