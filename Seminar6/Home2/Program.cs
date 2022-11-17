// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InputCoefficients(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] PointCalculation(double[,] coeff)
{
    double[] point = new double[2];
    point[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);  // x = (b2-b1)/(k1-k2)
    point[1] = point[0] * coeff[0, 0] + coeff[0, 1];                  // y = x*k1 + b1
    return point;
}

double[,] coefficient = new double[2, 2];

InputCoefficients(coefficient);
double[] crossPoint = PointCalculation(coefficient);
Console.WriteLine();
Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");




