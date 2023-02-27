// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int ThirdNumber(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool Validate(int num)
{
    if (num >= 100)
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет");
    return false;
}

int number = Prompt("Введите число");
if (Validate(number))
{
    System.Console.WriteLine(ThirdNumber(number));
}