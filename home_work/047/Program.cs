void FillArray(double[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(0, 11) + rnd.NextDouble(); // еще можно просто rnd.NextDouble()*100, так как NextDouble генерирует от 0 до 1
        }
    }
}

void PrintArray(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write("{0,6:f2}", coll[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);