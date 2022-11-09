// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int NumberSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
      sum = sum + number % 10;
      number = number / 10;
    }
   return sum;
}

int number = Prompt("Введите число: ");
int sumNumber = NumberSum(number);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");
