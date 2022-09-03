/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] GenerateArray()
{
  int[] array = new int[new Random().Next(2, 10)];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
  }
  Console.WriteLine("]");
}
void ArrayMaxMin(int[] array)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = 0; j < array.Length; j++)
    {
      if (array[i] - array[j] > result) result = array[i] - array[j];
    }
  }
  Console.WriteLine("Разница между максимальным и минимальным элементoм массива = " + result);
}

int[] arr = GenerateArray();
PrintArray(arr);
ArrayMaxMin(arr);