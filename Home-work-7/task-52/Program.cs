/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] ArithmeticMeanInColumns(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = default;
        for (int i = 0; i < matr.GetLength(0); i++)  
        {
            sum = sum + matr[i, j];
        } 
        result[j] = Math.Round((sum / matr.GetLength(0)), 1);
    }
    return result;
}
double[] res = ArithmeticMeanInColumns(matrix);
Console.Write("Среднее арифметическое каждого столбца:");
PrintArray(res);


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

void PrintArray(double[] array) 
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ");
}
