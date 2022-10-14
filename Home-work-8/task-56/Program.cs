/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк ");
int rows;
rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns;
columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива ");
int min;
min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива ");
int max;
max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(matrix);
int a = MaxSummDigitInRows(matrix);
Console.WriteLine($" Минимальная сумма чисел находится в строке {a}");



int MaxSummDigitInRows(int[,] matr)
{
    int min = 0;
    int summ = default;
    int minsumm = default;
    int i = 0;
    for (int j = 0; j < matr.GetLength(1); j++)  
    {
        minsumm = minsumm + matr[0, j];
    }
    while(i < matr.GetLength(0))
    {
        for (int j = 0; j < matr.GetLength(1); j++)  
        {
            summ = summ + matr[i, j];
        }
    if(summ < minsumm)
    {
        minsumm = summ;
        min = i;
        summ = 0;
        i++;
    }
    else
    summ = 0;
    i++;
    }
    int result = min + 1;
    return result;
}



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //(0) - rows
    {
      for (int j = 0; j < matrix.GetLength(1); j++)  //(1)- columns
        {
             matrix[i, j] = rnd.Next(min, max + 1);
        } 
    } 
    return matrix;
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} | ");
            else Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine(" |");
    } 
}