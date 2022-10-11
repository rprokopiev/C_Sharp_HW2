int [] Weekday = {1, 2, 3, 4, 5};
Console.WriteLine("Введите цифру (1-7), обозначающую день недели ");
string number = Console.ReadLine();
int N = int.Parse(number);
int count = 0;
if (N < 8)
{   if (N<=Weekday.Length)
    {
        while (count <= Weekday.Length)
        {
            if (N==Weekday[count])
            {
                Console.WriteLine("НЕТ");
                break;
            }
            count = count +1;
        }
    }
    else
    {
        Console.WriteLine("ДА");
    }
}
else
{
    Console.WriteLine("Ошибка, написано же - от 1 до 7");
}