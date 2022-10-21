// Задача 1: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число: ");

int pal = number;
int temp = 0;
while (number > 0) 
{
    temp = temp * 10 + number % 10; 
    number /= 10;
}

if (pal == temp)
{
    Console.WriteLine($"{pal} -> полиндром");
}
else
{
    Console.WriteLine($"{pal} -> не полиндром");
}
