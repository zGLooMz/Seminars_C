// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int Prompt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }

}

int SumNegativePos(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
        {
            sumElements = sumElements + array[i];
        }
    }
    return sumElements;
}
int len = Prompt("Введите размерность массива: ");
int min = Prompt("Введите минимальный порог случайных значений: ");
int max = Prompt("Введите максимальный порог случайных значений: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
int quantity = SumNegativePos(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {quantity}");