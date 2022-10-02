Console.WriteLine("Введите пятизначное число ");
int number;
number = Convert.ToInt32(Console.ReadLine());

int twofirstdigit = number / 1000;

while (number > 100)
{
    number = number % 100;
}

int twolastnumber = number % 10 * 10 + number / 10;

if (twofirstdigit == twolastnumber) 
Console.WriteLine("Данное число палиндром");
else 
Console.WriteLine("данное число не палиндром");
