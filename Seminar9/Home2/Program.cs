// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов: {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}
PrintSumm(m, n, 0);