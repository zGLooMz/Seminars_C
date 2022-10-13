// *. Напишите программу вычисления модуля числа.
// 	 2 -> 2
// 	-3 -> 3
// 	-7 -> 7

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int mod = number;
if(number<0) 
    mod = -number;

Console.WriteLine($"{mod} модуль числа {number}");
