Console.WriteLine("Введите пятизначное число ");
int number;
number = Convert.ToInt32(Console.ReadLine());
if ( number > 99999 || number < 10000) 
Console.WriteLine("Данное число не пятизначное");
int firsttwodigit = number / 1000;

while (number > 100)
{
    number = number % 100;
}

int lasttwonumber = number % 10 * 10 + number / 10;

if (firsttwodigit == lasttwonumber) 
Console.WriteLine("Данное число палиндром");
else 
Console.WriteLine("данное число не палиндром");
