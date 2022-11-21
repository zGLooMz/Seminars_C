// Задача 2: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

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

void FindElement(int[,] array, int posI, int posJ)
{
    if (posI < array.GetLength(0)      
     && posJ < array.GetLength(1))
    {
        Console.WriteLine($"Позиции [{posI}, {posJ}] соответствует число {array[posI, posJ]}");
        return;
    }
    Console.WriteLine($"Такого элемента нет в массиве");
}
int m = PromptInt("Введите количество строк: ");
int n = PromptInt("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
int posI = PromptInt("Введите позицию элемента в строке(i): ");
int posJ = PromptInt("Введите позицию элемента в столбце(j): ");
FindElement(matrix, posI, posJ);

