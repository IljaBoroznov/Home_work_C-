Console.WriteLine("Введите число ");
int number;
number = Convert.ToInt32(Console.ReadLine());
if ( number < 99 ) Console.WriteLine($"Третья цифра цисла {number} отсутствует");
if ( number < 999 && number > 99 )
{
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра цисла {number} => {thirdDigit}");
}
int num = number;
if ( number > 999 )
{
        while( num > 999 )
        {
        num = num / 10;
        }
    int thirdDigit = num % 10;
    Console.WriteLine($"Третья цифра цисла {number} => {thirdDigit}");
}
