// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

void Print(int n, int k)
{
    int limitN = (k + 1) * k / 2;     // количество чисел в последовательности в зависимости от k 

    for (int i = limitN - k; i < limitN & i < n; i++)
        Console.Write($"{k} ");

    if (limitN < n) Print(n, k + 1);

}
int n = Prompt("Введите количество первых чисел последовательности: ");
Print(n, 1);