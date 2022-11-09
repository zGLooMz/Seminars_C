// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Реализовать через функции.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message + ": ");
    return int.Parse(Console.ReadLine());
}

int Exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    
    return result;
}

int numberA = Prompt("Введите число A");
int numberB = Prompt("Введите число B");

int exponent = Exponent(numberA, numberB);

Console.WriteLine($"А в степени В равно {exponent}");

// Решение через Math.Pow
// 
// double Exponent(int numberA, int numberB)
// {
//     double result = Math.Pow(numberA, numberB);
//     return result;
// }

// int numberA = Prompt("Введите число A");
// int numberB = Prompt("Введите число B");
// double exponent = Exponent(numberA, numberB);
// Console.WriteLine($"А в степени В равно {exponent}");