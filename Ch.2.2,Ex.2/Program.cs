delegate void CharAssigner(char symb);
class CharForEveryObject
{
    char symb;
    void AssignChar(char symb)
    {
        this.symb = symb;
    }
    CharForEveryObject[] objs = new CharForEveryObject[3];
    static void Main(string[] args)
    {
        CharForEveryObject obj = new CharForEveryObject();
        CharForEveryObject obj2 = new CharForEveryObject();
        obj.objs[0] = obj2;
        CharForEveryObject obj3 = new CharForEveryObject();
        obj.objs[1] = obj3;
        CharForEveryObject obj4 = new CharForEveryObject();
        obj.objs[2] = obj4;
        CharAssigner del = new CharAssigner(obj.AssignChar);
        del += obj2.AssignChar;
        del += obj3.AssignChar;
        del += obj4.AssignChar;
        del('h');
        Console.WriteLine(obj.symb);
        Console.WriteLine(obj2.symb);
        Console.WriteLine(obj3.symb);
        Console.WriteLine(obj4.symb);
    }
}