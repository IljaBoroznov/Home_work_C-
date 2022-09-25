Console.WriteLine("Введите номер дня недели ");
int number;
number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("нет");
        break;
    case 2:
        Console.WriteLine("нет");
        break;
    case 3:
        Console.WriteLine("нет");
        break;
    case 4:
        Console.WriteLine("нет");
        break;
    case 5:
        Console.WriteLine("близко, но нет");
        break;
    case 6:
        Console.WriteLine("ДААА!");
        break;
    case 7:
        Console.WriteLine("ДААА!!");
        break;
    default:
        Console.WriteLine("Неверный номер дня недели");
        break;
}