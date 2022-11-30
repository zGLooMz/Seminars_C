// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintNumber(int n, int m)
{
    if (m > n) return;
    else if (m % 2 == 0)
        Console.Write($"{m}, ");
    PrintNumber(n, m + 2);
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

PrintNumber(n, m);
