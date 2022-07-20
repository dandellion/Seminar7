double [,] InitMatrix(int m, int n)
{
    double [,] matrix = new double[m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = Math.Round(randomizer.NextDouble()*100-50, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер матрицы:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double[,] matrix = InitMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");
PrintMatrix(matrix);