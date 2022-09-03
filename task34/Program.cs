/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GenerateArray()
{
  int[] array = new int[new Random().Next(2, 10)];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
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
int CheckTwo(int[] array)
{
  int check = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) check++;
  }
  return check;
}

int[] arr = GenerateArray();
PrintArray(arr);
Console.WriteLine("количество чётных чисел в массиве " + CheckTwo(arr));