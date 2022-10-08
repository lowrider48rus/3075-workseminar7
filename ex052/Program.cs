// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Convert.ToInt32(**.ToString())

Console.WriteLine("Введи количество строк (m): ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов (n): ");
int n = Int32.Parse(Console.ReadLine());

double[,] matrix = new double [m, n];

Console.WriteLine("Введи минимальное значение: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Создан массив: ");
FillArray(matrix, min, max);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Создан массив со средними арфиметическими элементов столбцов: ");
double[] res = average(matrix);

Console.WriteLine(String.Join(" ", res));
void PrintArray(double[,] matr){
    for (int i = 0; i < Convert.ToInt32(matr.GetLength(0).ToString()); i++)
    {
        for (int j = 0; j < Convert.ToInt32(matr.GetLength(1).ToString()); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(double[,] matr, int min, int max)
{
    for (int i = 0; i < Convert.ToInt32(matr.GetLength(0).ToString()); i++)
    {
        for (int j = 0; j < Convert.ToInt32(matr.GetLength(1).ToString()); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    Console.WriteLine();
    }
}

double[] average(double[,] matr)
{
    double[] result = new double[Convert.ToInt32(matr.GetLength(1).ToString())];
    for (int j = 0; j < Convert.ToInt32(matr.GetLength(1).ToString()); j++)
    {
        for (int i = 0; i < Convert.ToInt32(matr.GetLength(0).ToString()); i++)
        {
           result[j] +=matr[i, j]; 
        }
}
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(result[i] / matr.GetLength(0),2);
    }
    return result;
}
