/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] firstMatrix = InitMatrix(m, n);
Console.WriteLine($"1 Матрица размером {m}x{n}:");
PrintMatrix(firstMatrix);

int[,] secondMatrix = InitMatrix(m, n);
Console.WriteLine($"2 Матрица размером {m}x{n}:");
PrintMatrix(secondMatrix);


int[,] resultMatrix = new int[m,n];
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

 void MultipMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
   
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        resultMatrix[i,j] = firstMartrix[i,j] * secondMartrix[i,j];
    }
  }
}
