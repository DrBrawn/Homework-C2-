// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(System.Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 100 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Это число не трехзначное");
    return false;
}

int number = Prompt("Введите трехзначное число");

if (Validate(number))
{
    int secondDigit = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
}