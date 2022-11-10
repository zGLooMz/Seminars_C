// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int amount = Prompt("Введите количество элементов массива");
int min = Prompt("Введите минимальный порог случайных значений");
int max = Prompt("Введите максимальный порог случайных значений");

int[] CreateArray(int Length)
{

    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

Console.Write($"Случайный массив из {amount} элементов со значениями от {min} до {max}: ");
int[] Array = CreateArray(amount);
printArray(Array);

