// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillMatrixWhithRandomNumbers(double[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() + rand.Next(-1, 11), 2);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

int FindPositionOfNumber(double[,] matrix, double x)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (x == matrix[i, j])
            {
                Console.WriteLine($"{x} находится на позиции: {i}, {j}");
            }
            else
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
Console.Write("\n");

// ПОИСК ЧИСЛА ПО ПОЗИЦИЯМ

// Console.Write("Введите позицию элемента в строке: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию элемента в столбце: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if(x > m || y > n || x < 0 || y < 0) { Console.Write("Такого числа нет");}
// else {Console.Write($"Элемент, стоящий на данных позициях: {matrix[x, y]}");}

// ПОИСК ПОЗИЦИЙ ПО ЧИСЛУ

Console.Write("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
if (FindPositionOfNumber(matrix, x) == m * n) { Console.Write("Такого числа нет"); }