Console.WriteLine("Введите число N ");
int n;
n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while( count <= n)
{
    Console.WriteLine( $" куб числа {count} = {count * count * count} ");
    count++;
}
