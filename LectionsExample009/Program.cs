int[] array = { 1, 12, 31, 34, 53, 64, 37, 28 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{

  if (array[index] == find)
  {
    Console.WriteLine(index);
  }
  // index = index + 1;
  index++;
}