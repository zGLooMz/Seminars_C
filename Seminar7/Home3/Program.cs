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

double[] AverageColumns(int[,] matr)
{
    double[] average = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            average[j] += matr[i, j];
        }
        average[j] = average[j] / matr.GetLength(0);
        
    }
    return average;
}
void PrintAverage (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}; ");
}

int m = PromptInt("Введите количество строк: ");
int n = PromptInt("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: "); 
PrintAverage(AverageColumns(matrix));