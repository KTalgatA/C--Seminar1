Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine() ?? "");
if (a < 100)
{
  Console.Write("Ошибка, необходимо ввести трехзначное число!!!");
}
else if (a > 999)
{
  Console.Write("Ошибка, необходимо ввести трехзначное число!!!");
}
int result = a - a / 10 * 10;
Console.WriteLine($" {a} -> {result} ");