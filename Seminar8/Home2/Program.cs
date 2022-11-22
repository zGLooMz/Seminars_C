// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumElementsString(int[,] array)
{
    int[] sumString = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString[i] += array[i, j];
        }
    }
    return sumString;
}

int MinSumElements(int[] array)
{
    int minSum = array[0];
    int indexString = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (minSum > array[i])
        {
            minSum = array[i];
            indexString = i;
        }
    }
    return indexString;
}

int rows = Prompt("Enter quantity of raws ");
int columns = Prompt("Enter quantity of columns ");
int lowLim = Prompt("Enter lower limit for array element value");
int upperLim = Prompt("Enter upper limit for array element value");
int[,] baseArray = CreateArray(rows, columns, lowLim, upperLim);
Console.WriteLine();
PrintArray(baseArray);
int[] sum = SumElementsString(baseArray);
Console.WriteLine($"Минимальная сумма элементов в строке {MinSumElements(sum)}");
