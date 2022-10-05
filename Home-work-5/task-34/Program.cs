/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите длину массива ");
int length;
length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(length);
int evenDigit = CounterEvenDigit(array);

Console.Write("В массиве ");
PrintArray(array);
Console.WriteLine($" -> количество четных чисел = {evenDigit} ");

int CounterEvenDigit(int[] arr)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    
    }
    return count;
}

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = rnd.Next(99, 1000);
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