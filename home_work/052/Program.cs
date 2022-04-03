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
            Console.Write($"{coll[i, j], -3}");
        }
        Console.WriteLine();
    }
}

void Mean(int[,] coll)
{
    int i = 0;
    int mean = 0;
    int columns = 1;
    for (int j = 0; j < coll.GetLength(1); j++)
    {
        while (i < coll.GetLength(0))
        {
            mean += coll[i, j];
            i++;
        }
        Console.WriteLine($"{columns} column's mean = {mean}");
        columns++;
        mean = 0;
        i = 0;
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Mean(matrix);