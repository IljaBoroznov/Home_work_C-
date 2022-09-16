Console.WriteLine("Введите число ");
int x;
x = Convert.ToInt32(Console.ReadLine());

if ((x % 2) == 0) // проверка на четность
{
    Console.WriteLine("четное ");
}
else
{
    Console.WriteLine("нечетное ");
}
