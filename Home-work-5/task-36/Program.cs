/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


Console.WriteLine("Введите длину массива ");
int length;
length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(length);
int summ = SummDigitOddPosition(array);
Console.Write("Сумма чисел с нечетными индексами в массиве ");
PrintArray(array);
Console.WriteLine($" = {summ} ");


int SummDigitOddPosition(int[] arr)
{
    int summ = default;
    int i = 1;
    while( i < array.Length )
    {
    summ = summ + arr[i];
    i = i +2;  
    }
    return summ;
}

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}