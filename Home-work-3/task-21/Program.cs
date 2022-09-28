Console.WriteLine("Введите Х точки А ");
int ax;
ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите У точки А  ");
int ay;
ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки A  ");
int az;
az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Х точки В ");
int bx;
bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите У точки В  ");
int by;
by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки В  ");
int bz;
bz = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb)); // квадратный корень из числа
double resultRound = Math.Round(result, 2); // округление до 2 знаков после запятой


Console.WriteLine($" AB = {resultRound}");
