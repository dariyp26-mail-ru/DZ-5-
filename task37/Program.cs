/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] GenerateArray()
{
  int[] array = new int[new Random().Next(2, 10)];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 10);
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
int[] MultArr(int[] array)
{
  int length = 0;
  if (array.Length % 2 == 0) length = array.Length / 2;
  else length = array.Length / 2 + 1;
  
  int[] new_array = new int[length];
  int i = 0;
  int j = array.Length - 1;
  while (j >= i)
  {
    if (j == i) new_array[i] = array[i];
    else new_array[i] = array[i] * array[j];
    i++;
    j--;
  }
  return new_array;
}

int[] arr = GenerateArray();
PrintArray(arr);
int[] arr2 = MultArr(arr);
PrintArray(arr2);