/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.WriteLine("Введите значение B1 ");
double b1;
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение B2 ");
double b2;
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение K1 ");
double k1;
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение K2 ");
double k2;
k2 = Convert.ToDouble(Console.ReadLine());
InterseptionPoint(b1, b2, k1, k2);

void InterseptionPoint(double a1, double a2, double b1, double b2)
{
    double x = (a2 - a1) / (b1 - b2);
    double y = b2 * x + a2;
    Console.Write($" B1 = {a1}, B2 = {a2}, K1 = {b1} K2 = {b2} -> ({x}; {y}) ");
    Console.WriteLine();
}

