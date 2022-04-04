void FillArray(double[,] coll)
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

void PrintArray(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j], -5}");
        }
        Console.WriteLine();
    }
}

void Mean(double[,] coll)
{
    int i = 0;
    double mean = 0;
    int columns = 1;
    for (int j = 0; j < coll.GetLength(1); j++)
    {
        while (i < coll.GetLength(0))
        {
            mean += coll[i, j];
            i++;
        }
        Console.WriteLine($"{columns} column's mean = {mean / coll.GetLength(0):f1}");
        columns++;
        mean = 0;
        i = 0;
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Mean(matrix);