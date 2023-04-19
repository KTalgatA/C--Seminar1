Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Все целые числа в промежутке от -N до N: ");
for (int i = -N; i <= N; i++)
{
  Console.Write(i + " ");
}