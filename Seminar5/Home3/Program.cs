// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

int Prompt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max) * 1.1;
    }
    return tempArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0],0:F1}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i],0:F1}");
    }

}

double DifMaxMin(double[] array)
{
    double difference = 0;
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i]) maxNumber = array[i];

        if (minNumber > array[i]) minNumber = array[i];
    }
    difference = maxNumber - minNumber;
    return difference;
   
}

int len = Prompt("Введите размерность массива: ");
int min = Prompt("Введите минимальный порог случайных значений: ");
int max = Prompt("Введите максимальный порог случайных значений: ");
double[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
double quantity = DifMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {quantity,0:F1}");

