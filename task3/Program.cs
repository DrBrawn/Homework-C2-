// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(System.Console.ReadLine());
}

bool Validate(int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели.");
    return false;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

int weekDay = Prompt("Введите день недели");
if (Validate(weekDay))
{
    if (IsWeekend(weekDay))
    {
        System.Console.WriteLine("Выходной!");
    }
    else
    {
        System.Console.WriteLine("На работу.");  
    } 
}