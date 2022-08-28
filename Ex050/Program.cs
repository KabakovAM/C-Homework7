// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateFillMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void ReturnElementByIndex(int[,] matrix, int row, int col)
{
    if (matrix.GetLength(0) < row - 1 || matrix.GetLength(1) < col - 1)
        Console.Write("Такого элемента в массиве нет");
    else Console.Write($"Искомый элемент - {matrix[row - 1, col - 1]}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.WriteLine($"{matrix[i, j]}]");
        }
    }
}

int[,] mat = CreateFillMatrix(5, 5, 1, 9);
PrintMatrix(mat);
Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine());
ReturnElementByIndex(mat, m, n);