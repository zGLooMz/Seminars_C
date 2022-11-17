// Задача 3: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CreatArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine();
}

int SumStringMax(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max = arr[i, 0];

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (max < arr[i, j]) max = arr[i, j];
        }
        sum += max;
    }
    return sum;
}
int SumColumnMin(int[,] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int min = arr[0, j];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (min > arr[i, j]) min = arr[i, j];
        }
        sum += min;
    }
    return sum;
}

int[,] matrix = new int[2, 3];
CreatArray(matrix);
PrintArray(matrix);

Console.WriteLine($"Сумма максимальных значений по каждой строке: {SumStringMax(matrix)}");
Console.WriteLine($"Сумма минимальных значение по каждой колонке: {SumColumnMin(matrix)}");

Console.WriteLine($"Разница между максимумами и минимумами: {SumStringMax(matrix) - SumColumnMin(matrix)}");
