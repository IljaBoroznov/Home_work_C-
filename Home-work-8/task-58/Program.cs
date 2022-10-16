/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
int[,] matrix2 = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] newmatrix = UmnozhitMatrix(matrix, matrix2);
Console.WriteLine($"Результат умножения");
PrintMatrix(newmatrix);


int[,] UmnozhitMatrix(int[,] matr, int[,] matr2)
{
    int[,] newmatr = new int[matr.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(0); n++)
            {
                newmatr[i, j] = newmatr[i, j] + matr[i, n] * matr2[n, j];
            }
        
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} ");
            else Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine(" |");
    } 
}