Console.WriteLine("Введите число ");
int n;
n = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine()) Метод конвертирует тип строки string в число
int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
int index = 0;
while (index < n )
{
    if ((array[index] % 2) == 0)
    {
    Console.WriteLine(array[index]);
    }
 index = index + 1;
}


   