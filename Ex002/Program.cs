﻿Console.Write("Задайте номер дня недели в числовом формате: ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
if (a == 1)
{
  Console.WriteLine("Monday");
}
else if (a == 2)
{
  Console.WriteLine("Tuesday");
}
else if (a == 3)
{
  Console.WriteLine("Wednesday");
}
else if (a == 4)
{
  Console.WriteLine("Thursday");
}
else if (a == 5)
{
  Console.WriteLine("Fryday");
}
else if (a == 6)
{
  Console.WriteLine("Saturday");
}
else if (a == 7)
{
  Console.WriteLine("Sunday");
}
else
{
  Console.WriteLine("No such day");
}