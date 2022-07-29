/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

Console.Clear();
int[,,] InitMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x,y,z];
    Random randomizer = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
        {
            matrix[i,j,k] = randomizer.Next(10, 100);
        }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]}  ({i},{j},{k}) ");
            }   

        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число z:");
int z = int.Parse(Console.ReadLine());
int[,,] matrix = InitMatrix(x, y, z);
Console.WriteLine($"Матрица размером {x}x{y}x{z}:");
PrintMatrix(matrix);

