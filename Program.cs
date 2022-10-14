/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 7 -2 -85
1 -3 8 -9
8 7 -7 9 */

Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, -10, 10);
Printarray(array);





















int[,] Getarray(int m, int n, int minvalue, int maxvalue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return result;
}

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

