Console.Write("Введите число a: ");
string userInputa = Console.ReadLine() ?? "";
int userNumbera = int.Parse(userInputa);
Console.Write("Введите число b: ");
string userInputb = Console.ReadLine() ?? "";
int userNumberb = int.Parse(userInputb);

if (userNumbera / userNumberb == userNumberb)
{
  Console.Write($"a = {userNumbera} b = {userNumberb} -> Yes");
}
else
{
  Console.Write($"a = {userNumbera} b = {userNumberb} -> No");
}