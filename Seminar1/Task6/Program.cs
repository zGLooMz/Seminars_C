// **. Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

System.Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double back = 1/number;
Console.WriteLine($"{back:f2}");