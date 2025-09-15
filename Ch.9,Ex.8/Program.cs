class UsingStringAndInt
{
    uint inum;
    public int this[int index]
    {
        set
        {
            int num = 1 + index;
            int j = 1;
            for (int i = 0; i < num; i++)
            {
                j *= 10;
            }
            for (int i = 0; num < 1; i++)
            {
                inum = inum / 10;
            }
        }
    }
}