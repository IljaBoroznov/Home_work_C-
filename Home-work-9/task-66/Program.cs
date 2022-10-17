/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Ввидите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число N ");
int n = Convert.ToInt32(Console.ReadLine());

int summ = SumNaturalNumbersMN(m, n);
Console.WriteLine($"Сумма цифр от числа {m} до {n} = {summ}");


int SumNaturalNumbersMN(int m, int n)
{
    int result = n;
    if( n != m )  result += SumNaturalNumbersMN(m, n - 1);
    return result;  
}
