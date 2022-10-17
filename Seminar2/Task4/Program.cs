// 4. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool DivBy(int number)
{
    return (number % 7 == 0) && (number % 23 == 0);
}

int A = Prompt("Введите первое число: ");

if (DivBy(A))
    Console.WriteLine("да");
else
    Console.WriteLine("нет");