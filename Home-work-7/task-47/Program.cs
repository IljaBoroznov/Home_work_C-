/*
Задача 47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

Console.WriteLine($" m= {rows}, n= {columns} ");

double[,] matrix = CreateMatrixRndDouble(rows, columns, min, max);

PrintMatrix(matrix);




double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //(0) - rows
    {
      for (int j = 0; j < matrix.GetLength(1); j++)  //(1)- columns
        {
             matrix[i, j] = rnd.Next(min, max);
        } 
    }
        
    return matrix;
}


void PrintMatrix(double[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    } 
}
