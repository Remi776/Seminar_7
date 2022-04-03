void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = j + i;
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
void EvenRowsColums(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i += 2)
    {
        for (int j = 0; j < coll.GetLength(1); j += 2)
        {
            coll[i,j] *= coll[i,j];
        }
    }
}


int[,] matrix = new int[4, 4];
Console.WriteLine("Array");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("New array");
EvenRowsColums(matrix);
PrintArray(matrix);
