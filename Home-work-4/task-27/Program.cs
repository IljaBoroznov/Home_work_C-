Console.WriteLine("Введите число  ");
int number;
number = Convert.ToInt32(Console.ReadLine());

int SummDigit(int num)
{
    int order = num;
    int i = 1;
    while( order > 1)
    {
        order = order / 10;
        i++;
    }
        int result = default;
        switch (i)
        {
            case 1:
            Console.Write("сумма равна введенному числу  ");
            result = num;
                break;
            case 2:
            result = num / 10 + num % 10;
                break;
            case 3:
            result = num / 100 + num / 10 % 10 + num % 10;
                break;
            case 4:
            result = num / 1000 + num / 100 % 10 + num / 10 % 10 + num % 10;
                break; 
            case 5:
            result = num / 10000 + num / 1000 % 10 + num / 100 % 10 + num /10 % 10 + num % 10;
                break;  
            case 6:
            result = num / 100000 + num / 10000 % 10 + num / 1000 % 10 + num /100 % 10 + num / 10 % 10 + num % 10;
                break; 
            default:
            Console.WriteLine("превышен формат");
                break;
        }
return result;
}

//int summgigit = SummDigit(number);
Console.WriteLine(SummDigit(number));