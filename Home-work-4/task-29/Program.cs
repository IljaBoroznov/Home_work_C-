Console.WriteLine("Введите длину массива ");
int length;
length = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[length];
FillArray(array1);
PrintArray(array1);

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99);
    }
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}]");
    Console.WriteLine();
}
