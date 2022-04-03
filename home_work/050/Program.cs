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

void CheckElement(int[,] coll, int a)
{
    bool flag = false;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (a == coll[i, j]) flag = true;
        }
    }
    if (flag == true) Console.WriteLine($"Number {a} is in the array!");
    else Console.WriteLine("No such number exists in the array.");
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.Write("\nEnter the number: ");
int b = Convert.ToInt32(Console.ReadLine());
CheckElement(matrix, b);