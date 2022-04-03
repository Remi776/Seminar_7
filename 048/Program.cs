void FillPrintArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = j + i;
            Console.Write(coll[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
FillPrintArray(matrix);