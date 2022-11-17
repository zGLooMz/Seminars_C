// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt(string msg)
{
    Console.Write(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int[] InputNumbers(int arr)
{
    int[] massive = new int[arr];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = Prompt($"Введи {i + 1}-e число: ");
    }
    return massive;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}
int m = Prompt("Введи количество чисел (число М): ");
int[] massive = InputNumbers(m);
PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"Введено чисел больше 0: {CountPositive(massive)} ");