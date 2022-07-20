int [,] InitMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void FindAverage(int[,] matrix)
{
   float n = matrix.GetLength(0);
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    float sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j,i];
    }
    float average = sum/n;
    Console.Write($"{average} ");
    }
}
Console.WriteLine("Введите размер матрицы:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
FindAverage(matrix);