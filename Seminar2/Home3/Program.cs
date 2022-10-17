// Задача 3: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;
if (number > 99)
{   
    while(number > 99)
    
    {
        thirdDigit = number % 10;
        number = number / 10;
    }
    Console.WriteLine($"третья цифра -> {thirdDigit}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
