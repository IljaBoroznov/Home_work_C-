Console.WriteLine("Введите трёхзначное число ");
int number;
number = Convert.ToInt32(Console.ReadLine());
int secondDigit;
secondDigit = number / 10 % 10;

Console.WriteLine($"вторая цифра цисла {number} => {secondDigit}");