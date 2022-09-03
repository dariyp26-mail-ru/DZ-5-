/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GenerateArray()
{
  int[] array = new int[new Random().Next(2, 10)];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99, 100);
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
int SummTwo(int[] array)
{
  int summ = 0;
  for (int i = 1; i < array.Length; i = i + 2)
  {
    summ = summ + array[i];
  }
  return summ;
}

int[] arr = GenerateArray();
PrintArray(arr);
Console.WriteLine("сумма элементов, стоящих на нечётных позициях " + SummTwo(arr));