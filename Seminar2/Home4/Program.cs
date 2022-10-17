// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine($"{dayNumber} -> да, это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine($"{dayNumber} -> введеное число не день недели");
  }
  else 
  {
  Console.WriteLine($"{dayNumber} -> нет, это не выходной день");
  }


