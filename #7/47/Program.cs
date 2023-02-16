using System.Globalization;

double[,] array = new double[3, 4];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = 1+ rand.NextDouble() * (10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}