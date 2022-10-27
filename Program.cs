/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Задача 47");
Console.Write("Введите кол-во строк: ");
int rows47 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int columns47 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[,] array47 = GetArray47(rows47, columns47, -10, 10);
PrintArray47(array47);

double[,] GetArray47(int m, int n, double minValue, double maxValue){
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray47(double[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write(" {0:f1} ", (Array[i, j]));
        }
        Console.WriteLine();
    }
}

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */

Console.WriteLine("Задача 50");
Console.Write("Введите i индекс строки: ");
int i50 = int.Parse(Console.ReadLine()!);
Console.Write("Введите j индекс столбца: ");
int j50 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array50 = GetArray(5, 5, 0, 10);
PrintArray(array50);
ElementSearch(array50, i50, j50);
Console.WriteLine();

void ElementSearch(int[,] Array, int x, int y){
    for (int i = 0; i < Array.GetLength(0); i++)    {
        if ((x >= Array.GetLength(0)) || (y >= Array.GetLength(1)))        {
            Console.WriteLine("Такой позиции нет в массиве");
            break;
        }
        for (int j = 0; j < Array.GetLength(1); j++){
            if ((x == i) && (y == j)){
                Console.WriteLine($"Элемент на позиции [{x}, {y}] -> {Array[i, j]}");
            }
        }
    }
}

// /* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Задача 52");
int[,] array52 = GetArray(4, 4, 0, 5);
PrintArray(array52);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
ArithmeticMean(array52);
Console.WriteLine();

void ArithmeticMean(int[,] Array){
    for (int j = 0; j < Array.GetLength(1); j++){
        Double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++){
            sum += Array[i, j];
        }
        Console.Write($"{sum / Array.GetLength(0)} ");
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}