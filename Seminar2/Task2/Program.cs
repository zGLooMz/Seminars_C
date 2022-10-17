// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


int number = new Random().Next(10, 100);
int firsDigit = number / 10;
int lastDigit = number % 10;
if (firsDigit > lastDigit)
    Console.WriteLine($"{firsDigit} наибольшая цифра числа {number}");

else
    Console.WriteLine($"{lastDigit} наибольшая цифра числа {number}");

