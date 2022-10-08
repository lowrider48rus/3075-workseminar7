// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
Console.WriteLine();
Console.WriteLine("Создан массив со средними арфиметическими элементов столбцов: ");
int[] res = average(matrix);

Console.WriteLine(String.Join(" ", res));
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

int[] average(int[,] matr)
{
    int[] result = new int[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
           result[j] +=matr[i, j]; 
        }
}
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = result[i] / matr.GetLength(0);
    }
    return result;
}
