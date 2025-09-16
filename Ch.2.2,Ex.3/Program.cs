delegate char Charer();
class DelegateExemplarOperations
{
    public DelegateExemplarOperations(string str, bool bl)
    {
        txt = str;
        if (bl)
        {
            del = delegate () { return txt[0]; };
        }
        else
        {
            del = () => txt[txt.Length - 1];
        }
    }
    string txt;
    private Charer del;
    public Charer Exemplar
    {
        get { return del; }
    }

}
class Program
{
    static void Main(string[] args)
    {
        DelegateExemplarOperations obj = new DelegateExemplarOperations("Cats are cuddly!", true);
        DelegateExemplarOperations obj2 = new DelegateExemplarOperations("My dog is mischievous!", false);
        Console.WriteLine(obj.Exemplar());
        Console.WriteLine(obj2.Exemplar());
    }
}