/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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

int[,] matrix = InitMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);

Console.Write("Введите первую координату: ");
int i = int.Parse(Console.ReadLine());

Console.Write("Введите вторую координату: ");
int j = int.Parse(Console.ReadLine());

if (i < m && j < n && i >= 0 && j >= 0)
{
     Console.Write($"Значение элемента: {matrix[i, j]}");
}
else Console.Write($"такого элемента в массиве нет.");


