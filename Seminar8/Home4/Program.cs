// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateSpiralMatrix(int n, int temp = 1, int i = 0, int j = 0)
{
    int[,] spiralMatrix = new int[n, n];
    while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write($"{array[i, j]:D2} ");

        Console.WriteLine();
    }
}
int n = Prompt("Введите размерность n массива (n x n): ");
Console.WriteLine();
int[,] matrix = CreateSpiralMatrix(n);
WriteArray(matrix);