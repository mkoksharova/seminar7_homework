// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
void Avarage(int[,] array)
{
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое столбцов:");
        Console.WriteLine($" {Math.Round(sum / array.GetLength(0), 2)}");

        sum = 0;
    }
}
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
int[,] array = CreateArrayWithRandomNumbers(m, n);

PrintArray(array);
Console.WriteLine();
Avarage(array);
