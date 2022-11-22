// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArrayFirst(int rows, int columns, int lowerLim, int upperLim)
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

int[,] CreateArraySecond(int columns, int columns2nd, int lowerLim, int upperLim)
{
    int[,] table = new int[columns, columns2nd];
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

int[,] MultiplicationMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < firstMartrix.GetLength(1); n++)
            {
                sum += firstMartrix[i, n] * secondMartrix[n, j];          //Cij = Ai1 · B1j + Ai2 · B2j + ... + Ain · Bnj
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int rows = Prompt("Enter quantity of raws of the 1st matrix:");
int columns = Prompt("Enter quantity of columns of the 1st matrix (and rows of the 2nd):");
int columns2nd = Prompt("Enter quantity of columns of the 2nd matrix:");
int lowLim = Prompt("Enter lower limit for array element value");
int upperLim = Prompt("Enter upper limit for array element value");
int[,] firstArray = CreateArrayFirst(rows, columns, lowLim, upperLim);
int[,] secondArray = CreateArraySecond(columns, columns2nd, lowLim, upperLim);
Console.WriteLine();
PrintArray(firstArray);
PrintArray(secondArray);
MultiplicationMatrix(firstArray, secondArray);
Console.WriteLine("Произведение двух матриц:");
PrintArray(MultiplicationMatrix(firstArray, secondArray));