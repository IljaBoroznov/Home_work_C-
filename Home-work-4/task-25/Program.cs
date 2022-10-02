Console.WriteLine("Введите число A ");
int a;
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int b;
b = Convert.ToInt32(Console.ReadLine());

int DegreeAinB(int A, int B)
{
    int length = B;
    int result = A;
    for (int i = 1; i < length; i++ )
        {
            result = result * A;
        }
    return result;
}

int degree = DegreeAinB(a, b);

Console.WriteLine( $" {b}-я степень числа {a} = {degree} ");
