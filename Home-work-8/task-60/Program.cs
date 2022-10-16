/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

Console.WriteLine("Введите количество строк ");
int rows;
rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns;
columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину матрицы ");
int depth;
depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива ");
int min;
min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива ");
int max;
max = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = CreateMatrixRndInt(rows, columns, depth, min, max);

PrintMatrix(matrix);


bool SearchDigit(int[,,] matr, int x)
{
    int result = default;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                if( x == matr[i, j, z])
                {
                    result = 0;
                }
                else
                result = 1;

            }
        }
    }
    return result;
}

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    int check = default;
    int a = default;
    for (int i = 0; i < matrix.GetLength(0); i++)   //(0) - rows
    {
      for (int j = 0; j < matrix.GetLength(1); j++)  //(1)- columns
        {
            for (int z = 0; z < matrix.GetLength(2);)
            {
                a = rnd.Next(min, max + 1);
                bool Povtor;
                Povtor = false;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    for (int n = 0; n < matrix.GetLength(1); n++)
                    {
                        for (int m = 0; m < matrix.GetLength(2); m++)
                        {
                            
                            if(matrix[k, n, m] == a)
                            {
                                Povtor = true;
                                break;
                            }
                            
                        }
                
                    }
                }
            if(!Povtor)
            {
            matrix[i, j, z] = a;
            z++;
            }



                //check = SearchDigit(matrix, a);
                /*while(check == 1)
                {
                    a = rnd.Next(min, max + 1);
                    check = SearchDigit(matrix, a);
                }
                matrix[i, j, z] = a;
                */
                /*
                if(check == 1)
                {
                    matrix[i, j, z] = a;
                    z++;
                }
                */
                
                         
            }
        } 
    } 
    return matrix;
}

void PrintMatrix(int[,,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                if(z < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, z]}({i},{j},{z}) |");
                else Console.Write($"{matrix[i, j, z]}({i},{j},{z}) | ");
            }
        }
        Console.WriteLine("");
    } 
    
}