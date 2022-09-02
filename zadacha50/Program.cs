// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет





Console.WriteLine("Введите номер строки (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите номер столбца (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}
Console.WriteLine();

int[,] CreateArrayWithRandomNumbers(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{array[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

int ElementofReturn(int[,] array, int m, int n)
{
    int element = 0;

    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m - 1 && j == n - 1) element = array[i, j];
        }

    return element;

}
int[,] array = CreateArrayWithRandomNumbers(7, 5, 0, 100);
PrintArray(array);
Console.WriteLine();

if (ElementofReturn(array, m, n) > 0)
{
    Console.WriteLine("Значение выбранного элемента: " + ElementofReturn(array, m, n));
}
else
{
    Console.WriteLine("Этого нет элемента в массиве нет!");
}