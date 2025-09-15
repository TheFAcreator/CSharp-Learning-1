
class ObjectWithArrayFieldOperations
{
    int[] array;
    public ObjectWithArrayFieldOperations(int num)
    {
        array = new int[num];
        //for (int i = 0; i < num; i++)
        //{
        //    array[i] = 0;
        //}
    }

    public static string operator~(ObjectWithArrayFieldOperations obj)
    {
        string result = "";
        for (int i = 0; i < obj.array.Length; i++) 
        {
            result += obj.array[i] + " ";
        }
        return result;
    }
    public static ObjectWithArrayFieldOperations operator++(ObjectWithArrayFieldOperations obj)
    {
        obj = new ObjectWithArrayFieldOperations(obj.array.Length + 1);
        //obj.array[obj.array.Length - 1] = 0;
        return obj;
    }
    public static ObjectWithArrayFieldOperations operator--(ObjectWithArrayFieldOperations obj)
    {
        obj = new ObjectWithArrayFieldOperations(obj.array.Length - 1);
        return obj;
    }
    public static ObjectWithArrayFieldOperations operator+(ObjectWithArrayFieldOperations obj, ObjectWithArrayFieldOperations obj2)
    {
        var newObj = new ObjectWithArrayFieldOperations(obj.array.Length + obj2.array.Length);
        obj.array.CopyTo(newObj.array, 0);
        obj2.array.CopyTo(newObj.array, obj.array.Length);
        //for (int i = 0; i < obj.array.Length; i++)
        //{
        //    newObj.array[i] = obj.array[i];
        //}
        //for (int i = obj.array.Length; i - obj.array.Length < obj2.array.Length; i++)
        //{
        //    newObj.array[i] = obj2.array[i - obj.array.Length];
        //}
        return newObj;
    }
    public static ObjectWithArrayFieldOperations operator+(ObjectWithArrayFieldOperations obj, int i)
    {
        var newObj = new ObjectWithArrayFieldOperations(obj.array.Length + 1);
        newObj.array[^1] = i;
        return newObj;
    }
    public static ObjectWithArrayFieldOperations operator+(int i, ObjectWithArrayFieldOperations obj)
    {
        var newObj = new ObjectWithArrayFieldOperations(obj.array.Length + 1);
        
        newObj.array[0] = i;
        for (int j = 0; j < obj.array.Length; j++)
        {
            newObj.array[j + 1] = obj.array[j];
        }
        return newObj;
    }

    public void Show()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        var obj1 = new ObjectWithArrayFieldOperations(8);
        var obj2 = new ObjectWithArrayFieldOperations(7);

        obj1.Show();
        obj2.Show();

        string contents = ~obj1;
        Console.WriteLine(contents);

        obj1++;
        obj1.Show();
        
        obj1--;
        obj1.Show();
        
        var obj3 = obj1 + obj2;
        obj3.Show();
        
        var obj4 = obj1 + 1320;
        obj4.Show();
        
        var obj5 = 5674 + obj1;
        obj5.Show();
    }
}