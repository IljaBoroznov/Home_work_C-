/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет
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

Console.WriteLine("Введите искомую строку ");
int searchrows;
searchrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый столбец ");
int searchcolumns;
searchcolumns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(rows, columns, min, max);

int a = SearchElementInMatrix(matrix, searchrows, searchcolumns);

PrintMatrix(matrix);
if(a != -1)
{
    Console.WriteLine($"элемент из {searchrows} строки и {searchcolumns} столбца = {a}");
}
else 
Console.WriteLine($"элемент из {searchrows} строки и {searchcolumns} столбца отсутствует");



int SearchElementInMatrix(int[,] matrix, int rows, int columns)
{
    int result = default;
    if(rows <= matrix.GetLength(0) && columns <=  matrix.GetLength(1))
    {
        result = matrix[rows - 1, columns - 1];
    }
    else result = -1;
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
