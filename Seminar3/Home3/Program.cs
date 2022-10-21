﻿// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int number = Prompt("Введите число больше 0: ");

for (int i = 1; i <= number; i++) 
{
    Console.Write("{0}  ", Math.Pow(i, 3));
}