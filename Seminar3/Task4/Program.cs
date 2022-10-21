﻿//  Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int N = Prompt("Введите число больше 0: ");
int count = 1;  
while (count <= N)  
{
    System.Console.WriteLine(count * count); 
    count++; 
}
for (int i = 1; i <= N; i++) 
{
    System.Console.WriteLine(Math.Pow(i, 2));
}
