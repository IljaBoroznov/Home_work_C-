/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
Console.WriteLine();
int[,] newmatrix = ArrangeRows(matrix);
PrintMatrix(newmatrix);


int[,] ArrangeRows(int[,] matr)
{
    int[,] newmatr = new int[matr.GetLength(0), matr.GetLength(1)];
    int[] temp = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)   
        {
            temp[j] = matr[i, j];
        }
        Array.Sort(temp);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newmatr[i, j] = temp[j];
        }
    }
    return newmatr;
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