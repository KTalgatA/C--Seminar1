﻿Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "");
if (a % 2 == 0)
{
  Console.WriteLine($" {a} -> Да");
}
else
{
  Console.WriteLine($" {a} -> Нет");
}