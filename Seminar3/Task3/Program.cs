/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
// функция ввода числа с консоли
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int x1 = Prompt("Введите x1:");
int y1 = Prompt("Введите y1:");
int x2 = Prompt("Введите x2:");
int y2 = Prompt("Введите y2:");

int x = x1 - x2;
int y = y1 - y2;
double Lenght = Math.Sqrt(x * x + y * y);
Console.WriteLine($"{Lenght:f2}");





