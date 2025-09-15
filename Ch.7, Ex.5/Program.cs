class IndexOfSymbol
{
    static int[] GetIndexes(string txt, char searchedSymb)
    {
        int[] indexes;
        int check = 0;
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == searchedSymb) check++;
        }
        if(check == 0)
        {
            indexes = new int[1];
            indexes[0] = -1;
            return indexes;
        }
        else
        {
            indexes = new int[check];
            int k = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == searchedSymb)
                { 
                    indexes[k] = i;
                    k++;
                }
            }
            return indexes;
        }
    }
    static void Main(string[] args)
    {
        string txt = "Shouldn\'t you be studying?";
        char symb = 'o';
        int[] idxs = GetIndexes(txt, symb);
        foreach (int idx in idxs)
        {
            Console.Write(idx + " ");
        }
    }
}