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

void FindElementByPosition(int x, int y, int[,] matrix)
{
   int m = matrix.GetLength(0);
   int n = matrix.GetLength(1);
   if (x-1<m&&y-1<n)
        Console.WriteLine(matrix[x-1,y-1]);
    else  Console.WriteLine("There is no element");
}
Console.WriteLine("Введите размер матрицы:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("Введите номер строки и номер столбца искомого элемента");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
FindElementByPosition(x,y,matrix);