void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write(coll[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Summ(int[,] coll)
{
    int summ = 0;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (i == j) summ += coll[i, j];
        }
    }
    Console.WriteLine(summ);
}


int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Summ(matrix);
