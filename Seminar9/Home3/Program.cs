// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int AckermanFunctions(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunctions(m - 1, 1);
    else return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

Console.Write($"A(m,n) = {AckermanFunctions(m, n)} ");