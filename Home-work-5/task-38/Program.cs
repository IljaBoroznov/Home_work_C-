/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

Console.WriteLine("Введите длину массива ");
int length;
length = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndInt(length);
Console.Write(" Разница наибольшего и наименьшего числа массива ");
PrintArray(array);

double max = MaxDigit(array);
double min = MinDigit(array);
double result = default;

result = max - min;

Console.Write($" = {result}");
Console.WriteLine();



double MinDigit(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double MaxDigit(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

double[] CreateArrayRndInt(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = rnd.Next(-90, 90);
    }
    return array;
}

void PrintArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}



/*int summ = SummDigitOddPosition(array);
Console.Write("Сумма чисел с нечетными индексами в массиве ");
PrintArray(array);
Console.WriteLine($" = {summ} ");	
Console.WriteLine(Math.Round(1.5453, 1));
///Math.Round(1.5453, 1)

*/