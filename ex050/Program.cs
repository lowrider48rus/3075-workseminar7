// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введи количество строк (m): ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов (n): ");
int n = Int32.Parse(Console.ReadLine());

int[,] matrix = new int [m, n];

Console.WriteLine("Введи минимальное значение: ");
int min = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int max = Int32.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Создан массив: ");
FillArray(matrix, min, max);
PrintArray(matrix);

Console.WriteLine("Введи строку элемента (m): ");
int str = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи столбец элемента (n): ");
int stlb = Int32.Parse(Console.ReadLine());
search(matrix, str, stlb);

void PrintArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    Console.WriteLine();
    }
}

void search(int[,] matr, int row, int col)
{
    if((row > matr.GetLength(0)) || (col > matr.GetLength(1)))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Вывожу запрошенный элемент: {matr[row - 1, col - 1]}");
    }
}
