/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите количество чисел, которое вы хотите ввисти ");
int length;
length = Convert.ToInt32(Console.ReadLine());

int[] array = InitArray(length);
int result = HowMuchPositiveDigits(array);
Console.Write("в числах ");
PrintArray(array);
Console.Write($" положительных {result} шт. ");
Console.WriteLine();


int[] InitArray(int size)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int HowMuchPositiveDigits(int[] arr)
{
    int counter = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

void PrintArray(int[] array) // выводит без перескакивания на новую строку (добавить WriteLine)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}