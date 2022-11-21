// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("\n");
    }
}

void AverageColumns(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            average += matr[i, j];
        }
        average = average / matr.GetLength(0);
        Console.Write($"{average}; ");
    }
}
int m = PromptInt("Введите количество строк: ");
int n = PromptInt("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: "); 
AverageColumns(matrix);
