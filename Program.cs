/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 7 -2 -85
1 -3 8 -9
8 7 -7 9 */

/* 
Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, -10, 10);
Printarray(array);
 */

/* 
Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2->такого числа в массиве нет
i = 1, j = 2-> 2 */


/* 
Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, -10, 10);
Printarray(array);
PositionElement(array);

void PositionElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Введи позиции элемента по строке и по столбцу ");
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            if (rows == i && colums == j)
            {
                Console.WriteLine($"элемент позиции {rows}{colums} = {array[i, j]} ");
                break;
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
        }
    }
    Console.WriteLine();
}

 */


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, 0, 10);
Printarray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {averagecolums(array)}");

double averagecolums(int[,] array)
{
    double aver = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            aver = (aver + array[i, j]) / array.GetLength(0);
        }
    }
    return aver;
}





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

