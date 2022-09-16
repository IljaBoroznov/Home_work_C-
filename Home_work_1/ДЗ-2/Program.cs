Console.WriteLine("Введите первое число ");
int first;
first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int second;
second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int third;
third = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (second < first)
{
    max = first;
}
else
{
    max = second;
}
if (third < max)
{
   Console.Write("max = ");
   Console.WriteLine(max); 
}
else
{
   Console.Write("max = ");
   Console.WriteLine(third);  
}