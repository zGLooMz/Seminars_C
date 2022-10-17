// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Это число не трехзначное");
        return false;
    }
    return true;
}

int number = Prompt("Введите трехзначное число: ");
if(ValidateNumber(number))
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");
}






